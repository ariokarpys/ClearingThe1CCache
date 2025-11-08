using Microsoft.Win32;
using System;
using System.Linq;
using System.ServiceProcess;

namespace ОчисткаКэша1с
{
    internal class ServiceManager
    {
        public const string SERVICE_32 = "1C:Enterprise 8.3 Server Agent";
        public const string SERVICE_64 = "1C:Enterprise 8.3 Server Agent (x86-64)";

        public ServiceInfo GetServiceInfo(string serviceName)
        {
            try
            {
                using (var sc = new ServiceController(serviceName))
                using (var registryKey = Registry.LocalMachine.OpenSubKey($@"SYSTEM\CurrentControlSet\Services\{serviceName}"))
                {
                    string imagePath = registryKey?.GetValue("ImagePath")?.ToString() ?? "Не найден";

                    return new ServiceInfo
                    {
                        Name = serviceName,
                        Status = sc.Status,
                        ImagePath = imagePath,
                        Exists = true
                    };
                }
            }
            catch (UnauthorizedAccessException)
            {
                return new ServiceInfo
                {
                    Name = serviceName,
                    Status = ServiceControllerStatus.Stopped,
                    ImagePath = "Отказано в доступе. Запустите программу от имени администратора",
                    Exists = false
                };
            }
            catch (Exception ex)
            {
                return new ServiceInfo
                {
                    Name = serviceName,
                    Status = ServiceControllerStatus.Stopped,
                    ImagePath = $"Ошибка: {ex.Message}",
                    Exists = false
                };
            }
        }
       
        public (bool Success, string Message) RestartService(string serviceName)
        {
            try
            {
                using (ServiceController sc = new ServiceController(serviceName))
                {
                    // Проверяем существование службы
                    if (!ServiceExists(serviceName))
                        return (false, $"Служба '{serviceName}' не найдена");

                    // Останавливаем службу
                    if (sc.Status == ServiceControllerStatus.Running ||
                        sc.Status == ServiceControllerStatus.StartPending)
                    {
                        sc.Stop();
                        sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30));
                    }

                    // Запускаем службу
                    if (sc.Status == ServiceControllerStatus.Stopped ||
                        sc.Status == ServiceControllerStatus.StopPending)
                    {
                        sc.Start();
                        sc.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                    }

                    return (true, $"Служба '{serviceName}' успешно перезапущена");
                }
            }
            catch (UnauthorizedAccessException)
            {
                return (false, "Отказано в доступе. Запустите программу от имени администратора");
            }
            catch (Exception ex)
            {
                return (false, $"Ошибка перезапуска службы '{serviceName}': {ex.Message}");
            }
        }

        public (bool Success, string Message) EnableDebugMode(string serviceName)
        {
            try
            {
                using (var registryKey = Registry.LocalMachine.OpenSubKey($@"SYSTEM\CurrentControlSet\Services\{serviceName}", true))
                {
                    if (registryKey == null)
                        return (false, $"Служба '{serviceName}' не найдена в реестре");

                    string imagePath = registryKey.GetValue("ImagePath")?.ToString();
                    if (string.IsNullOrEmpty(imagePath))
                        return (false, "Не удалось получить путь к службе");

                    // Проверяем, не включен ли уже debug режим
                    if (imagePath.EndsWith(" -debug", StringComparison.OrdinalIgnoreCase))
                    {
                        // Убираем параметр -debug
                        string newImagePath = imagePath.Substring(0, imagePath.Length - 7).Trim();
                        registryKey.SetValue("ImagePath", newImagePath, RegistryValueKind.ExpandString);

                        return (true, $"Debug режим выключен для службы '{serviceName}'");
                    }
                    else
                    {
                        // Добавляем параметр -debug
                        string newImagePath = imagePath.Trim() + " -debug";
                        registryKey.SetValue("ImagePath", newImagePath, RegistryValueKind.ExpandString);

                        return (true, $"Debug режим включен для службы '{serviceName}'");
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                return (false, "Отказано в доступе. Запустите программу от имени администратора");
            }
            catch (Exception ex)
            {
                return (false, $"Ошибка изминения debug режима: {ex.Message}");
            }
        }

        private bool ServiceExists(string serviceName)
        {
            return ServiceController.GetServices().Any(s => s.ServiceName == serviceName);
        }


        public (bool Success, string Message) UpdateServiceVersion(string serviceName, string newVersion)
        {

            if (string.IsNullOrEmpty(newVersion))
            {
                return (false, "Версия не выбрана");
            }

            try
            {
                using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey($@"SYSTEM\CurrentControlSet\Services\{serviceName}", true))
                {
                    if (registryKey == null)
                        return (false, $"Служба '{serviceName}' не найдена в реестре");

                    string imagePath = registryKey.GetValue("ImagePath")?.ToString();
                    if (string.IsNullOrEmpty(imagePath))
                        return (false, "Не удалось получить путь к службе");

                    string updatedPath = UpdateVersionInPath(imagePath, newVersion);
                    if (updatedPath == null)
                    {
                        return (false, "Не удалось определить путь для обновления версии");
                    }

                    registryKey.SetValue("ImagePath", updatedPath, RegistryValueKind.ExpandString);
                    return (true, $"Версия службы '{serviceName}' обновлена на {newVersion}");
                }
            }
            catch (UnauthorizedAccessException)
            {
                return (false, "Отказано в доступе. Запустите программу от имени администратора");
            }
            catch (Exception ex)
            {
                return (false, $"Ошибка обновления версии: {ex.Message}");
            }
        }

        private string UpdateVersionInPath(string imagePath, string newVersion)
        {
            try
            {
                // Разбираем путь на составляющие
                string[] parts = imagePath.Split('\\');

                for (int i = 0; i < parts.Length - 1; i++)
                {
                    // Ищем часть пути, которая выглядит как версия 1С
                    if (parts[i].Length == 11 && IsValidVersion(parts[i]))
                    {
                        // Заменяем версию
                        parts[i] = newVersion;
                        return string.Join("\\", parts);
                    }
                }

                return null; // Версия не найдена в пути
            }
            catch
            {
                return null;
            }
        }
        private bool IsValidVersion(string version)
        {
            return version.StartsWith("8.3.") && version.Count(c => c == '.') == 3;
        }

    }

    public class ServiceInfo
    {
        public string Name { get; set; }
        public ServiceControllerStatus Status { get; set; }
        public string ImagePath { get; set; }
        public bool Exists { get; set; }
    }
}

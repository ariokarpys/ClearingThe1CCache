using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ОчисткаКэша1с
{
    internal class ProcessManager
    {
        string[] processNames = { "1cv8c", "1cv8s", "1cv8" };

        public (bool Success, string Message) KillOneCProcesses()
        {
            int totalKilled = 0;

            foreach (string processName in processNames)
            {
                try
                {
                    foreach (Process process in Process.GetProcessesByName(processName))
                    {
                        using (process)
                        {
                            process.Kill();

                            totalKilled++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    return (false, $"Ошибка : {ex.Message}");

                }
            }

            return (true, $"Завершено процессов: {totalKilled}");
        }

        public string FindProcessesLockingDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
                return "Каталог не существует";

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Процессы, блокирующие каталог:");
            result.AppendLine($"{directoryPath}");
            result.AppendLine(new string('-', 50));

            try
            {
                bool foundAny = false;
                FindProcessesRecursive(directoryPath, result, ref foundAny);

                if (!foundAny)
                {
                    result.AppendLine("Процессы не найдены - каталог не заблокирован");
                }

                return result.ToString();
            }
            catch (Exception ex)
            {
                return $"Ошибка проверки каталога: {ex.Message}";
            }
        }

        private void FindProcessesRecursive(string directory, StringBuilder result, ref bool foundAny)
        {
            try
            {
                // Проверяем файлы в текущей директории
                foreach (string file in Directory.GetFiles(directory))
                {
                    var processes = Win32Processes.GetProcessesLockingFile(file);
                    foreach (var process in processes)
                    {
                        foundAny = true;
                        result.AppendLine($"Файл: {Path.GetFileName(file)}");
                        result.AppendLine($"Процесс: {process.ProcessName} (ID: {process.Id})");
                        result.AppendLine($"Полный путь: {file}");
                        result.AppendLine(new string('-', 30));

                        process.Dispose();
                    }
                }

                // Рекурсивно проверяем поддиректории
                foreach (string subDir in Directory.GetDirectories(directory))
                {
                    FindProcessesRecursive(subDir, result, ref foundAny);
                }
            }
            catch (UnauthorizedAccessException)
            {
                result.AppendLine($"Нет доступа к: {directory}");
            }
            catch (Exception ex)
            {
                result.AppendLine($"Ошибка доступа к {directory}: {ex.Message}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace ОчисткаКэша1с
{
    internal class CacheManager
    {
        public IEnumerable<UserCacheInfo> FindCacheDirectories()
        {
            string systemPath = Path.GetPathRoot(Environment.SystemDirectory);

            string userPath = Path.Combine(systemPath, "Users");

            foreach (string userDir in Directory.GetDirectories(userPath))
            {
                DirectoryInfo userInfo = new DirectoryInfo(userDir);
                string userName = userInfo.Name;

                UserCacheInfo userCache = new UserCacheInfo { UserName = userName };

                // Проверяем различные возможные расположения кэша
                string[] possiblePaths = {
                    Path.Combine(userDir, "AppData", "Roaming", "1C", "1cv8"),
                    Path.Combine(userDir, "AppData", "Roaming", "1C", "1cv82"),
                    Path.Combine(userDir, "AppData", "Local", "1C", "1cv8"),
                    Path.Combine(userDir, "AppData", "Local", "1C", "1cv82"),
                };

                foreach (string path in possiblePaths)
                {
                    if (Directory.Exists(path))
                    {
                        userCache.CacheDirectories.AddRange(GetCacheSubdirectories(path));
                    }
                }

                yield return userCache;                
            }
        }

        public IEnumerable<UserCacheInfo> FindCacheDirectoriesSrv()
        {
            string systemPath = Path.GetPathRoot(Environment.SystemDirectory);

            UserCacheInfo userCache = new UserCacheInfo { UserName = "Серверный" };

            // Проверяем различные возможные расположения кэша
            string[] possiblePaths = {
                Path.Combine(systemPath, "Program Files (x86)", "1cv8", "srvinfo"),
                Path.Combine(systemPath, "Program Files", "1cv8", "srvinfo"),
            };

            foreach (string path in possiblePaths)
            {
                if (Directory.Exists(path))
                {
                    IEnumerable<string> registryDirs = Directory.EnumerateDirectories(path, "reg_*");
                    foreach (string regDir in registryDirs)
                    {
                        userCache.CacheDirectories.AddRange(GetCacheSubdirectories(regDir));
                    }
                }
            }

            yield return userCache;            
        }

        private IEnumerable<string> GetCacheSubdirectories(string parentPath)
        {
            foreach (string directory in Directory.GetDirectories(parentPath))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(directory);

                // GUID-подобные имена каталогов (36 символов)
                if (dirInfo.Name.Contains("-") && dirInfo.Name.Length == 36)
                {
                    yield return directory;
                }
                else if (dirInfo.Name.StartsWith("snccntx") && dirInfo.Name.Length == 43 && dirInfo.Name.Contains("-"))
                {
                    yield return directory;
                }
            }
        }

        public (bool Success, string Message) DeleteCacheDirectory(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                    return (false, "Каталог не существует");

                Directory.Delete(path, true);
                return (true, "Каталог успешно удален");
            }
            catch (UnauthorizedAccessException)
            {
                return (false, "Нет прав для удаления каталога");
            }
            catch (IOException ex)
            {
                return (false, $"Файлы заняты: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Ошибка: {ex.Message}");
            }
        }
    }

    public class UserCacheInfo
    {
        public string UserName { get; set; }
        public List<string> CacheDirectories { get; set; } = new List<string>();
    }
}
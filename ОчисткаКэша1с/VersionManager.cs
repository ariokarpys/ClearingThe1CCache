using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ОчисткаКэша1с
{
    internal class VersionManager
    {
        public List<string> FindInstalledVersions32Bit()
        {
            string systemPath = Path.GetPathRoot(Environment.SystemDirectory);
            string installPath = Path.Combine(systemPath, "Program Files (x86)", "1cv8");

            return FindInstalledVersionsInPath(installPath);
        }

        public List<string> FindInstalledVersions64Bit()
        {
            string systemPath = Path.GetPathRoot(Environment.SystemDirectory);
            string installPath = Path.Combine(systemPath, "Program Files", "1cv8");

            return FindInstalledVersionsInPath(installPath);
        }

        private List<string> FindInstalledVersionsInPath(string installPath)
        {
            List<string> versions = new List<string>();

            if (string.IsNullOrEmpty(installPath) || !Directory.Exists(installPath))
            {
                return versions;
            }

            try
            {
                foreach (string folder in Directory.GetDirectories(installPath))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(folder);
                    if (dirInfo.Name.Length == 11 && IsValidVersion(dirInfo.Name))
                    {
                        versions.Add(dirInfo.Name);
                    }
                }
            }
            catch { }

            return versions.OrderBy(v => v).ToList();
        }

        private bool IsValidVersion(string version)
        {
            return version.StartsWith("8.3.") && version.Count(c => c == '.') == 3;
        }
    }
}

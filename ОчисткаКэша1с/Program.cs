using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ОчисткаКэша1с
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0 && args[0] == "FullClear")
            {
                // Автоматическая очистка без UI
                DeleteAllCacheDir();
            }
            else
            {
                // Обычный запуск с интерфейсом
                Application.Run(new Form1());
            }
        }

        static void DeleteAllCacheDir()
        {
            CacheManager cacheManager = new CacheManager();
            ProcessManager processManager = new ProcessManager();

            List<UserCacheInfo> cacheDirectories = cacheManager.FindCacheDirectories().ToList();

            foreach (var userCache in cacheDirectories)
            {
                foreach (var cacheDir in userCache.CacheDirectories)
                {
                    (bool Success, string Message) deleteResult = cacheManager.DeleteCacheDirectory(cacheDir);
                }
            }
        }
    }
}

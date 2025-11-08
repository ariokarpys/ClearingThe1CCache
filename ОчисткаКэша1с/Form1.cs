using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace ОчисткаКэша1с
{
    public partial class Form1 : Form
    {
        private CacheManager _cacheManager;
        private ServiceManager _serviceManager;
        private readonly ProcessManager _processManager;
        private VersionManager _versionManager;

        public Form1()
        {
            InitializeComponent();

            // Создаем экземпляры менеджеров
            _cacheManager = new CacheManager();
            _serviceManager = new ServiceManager();
            _processManager = new ProcessManager();
            _versionManager = new VersionManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WiewDirs();

            UpdateServiceLabe();

            WiewVersions();
        }
        
        // Убийство всех процессов 1с 
        private void KillProc_button_Click(object sender, EventArgs e)
        {
            (bool Success, string Message) result = _processManager.KillOneCProcesses();

            if (!result.Success)
            {
                MessageBox.Show($"Ошибка: {result.Message}");
            }
        }
       
        // Кто занял файл
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Cache_dataGridView.CurrentRow != null)
            {
                string path = Cache_dataGridView.CurrentRow.Tag as string;

                if (!string.IsNullOrEmpty(path))
                {
                    string result = _processManager.FindProcessesLockingDirectory(path);
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Выберите каталог для проверки");
                }
            }
        }

        #region Работа с кэшем 1С
        // Обновление таблицы
        private void UpdateCacheDir_button_Click(object sender, EventArgs e)
        {
            WiewDirs();
        }

        // Вывод каталогов в таблицу
        public void WiewDirs()
        {
            Cache_dataGridView.Rows.Clear();

            foreach (var userCache in _cacheManager.FindCacheDirectories())
            {
                // Строка с именем пользователя
                int userRowIndex = Cache_dataGridView.Rows.Add();
                Cache_dataGridView.Rows[userRowIndex].Cells[0].Value = userCache.UserName;

                // Каталоги пользователя
                foreach (var cacheDir in userCache.CacheDirectories)
                {
                    int dirRowIndex = Cache_dataGridView.Rows.Add();
                    Cache_dataGridView.Rows[dirRowIndex].Cells[1].Value = cacheDir;
                    Cache_dataGridView.Rows[dirRowIndex].Tag = cacheDir;
                }
            }
        }

        // Удаление всех каталогов
        private void DeleteAllCacheDir_button_Click(object sender, EventArgs e)
        {
            int errorCount = 0;

            foreach (DataGridViewRow row in Cache_dataGridView.Rows)
            {
                string path = row.Tag as string;
                
                if (!string.IsNullOrEmpty(path))
                {
                    (bool Success, string Message) result = _cacheManager.DeleteCacheDirectory(path);
                    if (!result.Success)
                    {
                        errorCount++;
                    }
                }
            }

            if(errorCount > 0)
            {
                MessageBox.Show($"Ошибок удаления: {errorCount}");
            }

            WiewDirs();
        }

        // Открытие в проводнике каталога
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cache_dataGridView[1, Cache_dataGridView.CurrentRow.Index].Value != null)
            {
                if (System.IO.Directory.Exists(Cache_dataGridView[1, Cache_dataGridView.CurrentRow.Index].Value.ToString()))
                {
                    Process.Start("explorer", Cache_dataGridView[1, Cache_dataGridView.CurrentRow.Index].Value.ToString());
                }
            }
        }

        // Удаление одного каталога
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string path = Cache_dataGridView.CurrentRow.Tag as string;

            if (Cache_dataGridView.CurrentRow != null && (!string.IsNullOrEmpty(path)))
            {
                (bool Success, string Message) result = _cacheManager.DeleteCacheDirectory(path);
                
                if (!result.Success)
                {
                    MessageBox.Show($"Ошибка: {result.Message}");
                }
            }

            WiewDirs();
        }
        #endregion

        #region Управление службами 1С
        // Обновить службы
        private void UpdateService_button_Click(object sender, EventArgs e)
        {
            UpdateServiceLabe();

            WiewVersions();
        }
        
        private void UpdateServiceLabe()
        {
            ServiceInfo service32 = _serviceManager.GetServiceInfo(ServiceManager.SERVICE_32);
            ServiceInfo service64 = _serviceManager.GetServiceInfo(ServiceManager.SERVICE_64);

            ServiceState32_label.Text = "Статус службы: " + service32.Status;
            ServiceState64_label.Text = "Статус службы: " + service64.Status;

            ServiceReg32_label.Text = "Реестр: " + service32.ImagePath;
            ServiceReg64_label.Text = "Реестр: " + service64.ImagePath;
        }
        private void ServiceRestart32_button_Click(object sender, EventArgs e)
        {
            (bool Success, string Message) result = _serviceManager.RestartService(ServiceManager.SERVICE_32);

            if (!result.Success)
            {
                MessageBox.Show($"Ошибка: {result.Message}");
            }

            UpdateServiceLabe();
        }
        
        private void ServiceRestart64_button_Click(object sender, EventArgs e)
        {
            (bool Success, string Message) result = _serviceManager.RestartService(ServiceManager.SERVICE_64);

            if (!result.Success)
            {
                MessageBox.Show($"Ошибка: {result.Message}");
            }

            UpdateServiceLabe();
        }
        
        private void ServiceDebug32_button_Click(object sender, EventArgs e)
        {
            (bool Success, string Message) result = _serviceManager.EnableDebugMode(ServiceManager.SERVICE_32);

            if (!result.Success)
            {
                MessageBox.Show($"Ошибка: {result.Message}");
            }

            UpdateServiceLabe();
        }
       
        private void ServiceDebug64_button_Click(object sender, EventArgs e)
        {
            (bool Success, string Message) result = _serviceManager.EnableDebugMode(ServiceManager.SERVICE_64);

            if (!result.Success)
            {
                MessageBox.Show($"Ошибка: {result.Message}");
            }

            UpdateServiceLabe();
        }
        #endregion

        #region Работа с версиями 1С
        // Вывод версий 1с
        public void WiewVersions()
        {
            ServiceVer32_comboBox.Items.Clear();

            List<string> versions32 = _versionManager.FindInstalledVersions32Bit();

            foreach (string version in versions32)
            {
                ServiceVer32_comboBox.Items.Add(version);
            }

            ServiceVer64_comboBox.Items.Clear();

            List<string> versions64 = _versionManager.FindInstalledVersions64Bit();

            foreach (string version in versions64)
            {
                ServiceVer64_comboBox.Items.Add(version);
            }
        }

        private void ServiceUpdateVer32_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ServiceVer64_comboBox.Text))
                return;

            (bool Success, string Message) result = _serviceManager.UpdateServiceVersion(ServiceManager.SERVICE_32, ServiceVer32_comboBox.Text);

            if (!result.Success)
            {
                MessageBox.Show($"Ошибка: {result.Message}");
            }

            UpdateServiceLabe();
        }

        private void ServiceUpdateVer64_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ServiceVer64_comboBox.Text))
                return;

            (bool Success, string Message) result = _serviceManager.UpdateServiceVersion(ServiceManager.SERVICE_64, ServiceVer64_comboBox.Text);

            if (!result.Success)
            {
                MessageBox.Show($"Ошибка: {result.Message}");
            }

            UpdateServiceLabe();
        }
        #endregion
    }
}

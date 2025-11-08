namespace ОчисткаКэша1с
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cache_dataGridView = new System.Windows.Forms.DataGridView();
            this.Users = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cache_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateCacheDir_button = new System.Windows.Forms.Button();
            this.DeleteAllCacheDir_button = new System.Windows.Forms.Button();
            this.KillProc_button = new System.Windows.Forms.Button();
            this.ServiceState32_label = new System.Windows.Forms.Label();
            this.ServiceState64_label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UpdateService_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServiceUpdateVer64_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ServiceVer64_comboBox = new System.Windows.Forms.ComboBox();
            this.ServiceDebug64_button = new System.Windows.Forms.Button();
            this.ServiceRestart64_button = new System.Windows.Forms.Button();
            this.ServiceReg64_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServiceUpdateVer32_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ServiceVer32_comboBox = new System.Windows.Forms.ComboBox();
            this.ServiceRestart32_button = new System.Windows.Forms.Button();
            this.ServiceDebug32_button = new System.Windows.Forms.Button();
            this.ServiceReg32_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cache_dataGridView)).BeginInit();
            this.Cache_contextMenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cache_dataGridView
            // 
            this.Cache_dataGridView.AllowUserToAddRows = false;
            this.Cache_dataGridView.AllowUserToDeleteRows = false;
            this.Cache_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cache_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cache_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Users,
            this.Directory});
            this.Cache_dataGridView.ContextMenuStrip = this.Cache_contextMenuStrip;
            this.Cache_dataGridView.Location = new System.Drawing.Point(6, 6);
            this.Cache_dataGridView.MultiSelect = false;
            this.Cache_dataGridView.Name = "Cache_dataGridView";
            this.Cache_dataGridView.ReadOnly = true;
            this.Cache_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Cache_dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cache_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Cache_dataGridView.Size = new System.Drawing.Size(948, 449);
            this.Cache_dataGridView.TabIndex = 0;
            this.Cache_dataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Users
            // 
            this.Users.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Users.HeaderText = "Пользователи";
            this.Users.Name = "Users";
            this.Users.ReadOnly = true;
            this.Users.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Users.Width = 109;
            // 
            // Directory
            // 
            this.Directory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Directory.HeaderText = "Каталог";
            this.Directory.Name = "Directory";
            this.Directory.ReadOnly = true;
            this.Directory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cache_contextMenuStrip
            // 
            this.Cache_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.Cache_contextMenuStrip.Name = "contextMenuStrip1";
            this.Cache_contextMenuStrip.Size = new System.Drawing.Size(133, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem1.Text = "Удалить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem2.Text = "Кто занял?";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // UpdateCacheDir_button
            // 
            this.UpdateCacheDir_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateCacheDir_button.Location = new System.Drawing.Point(12, 12);
            this.UpdateCacheDir_button.Name = "UpdateCacheDir_button";
            this.UpdateCacheDir_button.Size = new System.Drawing.Size(93, 23);
            this.UpdateCacheDir_button.TabIndex = 1;
            this.UpdateCacheDir_button.Text = "Обновить";
            this.UpdateCacheDir_button.UseVisualStyleBackColor = true;
            this.UpdateCacheDir_button.Click += new System.EventHandler(this.UpdateCacheDir_button_Click);
            // 
            // DeleteAllCacheDir_button
            // 
            this.DeleteAllCacheDir_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAllCacheDir_button.Location = new System.Drawing.Point(111, 12);
            this.DeleteAllCacheDir_button.Name = "DeleteAllCacheDir_button";
            this.DeleteAllCacheDir_button.Size = new System.Drawing.Size(120, 23);
            this.DeleteAllCacheDir_button.TabIndex = 2;
            this.DeleteAllCacheDir_button.Text = "Удалить все";
            this.DeleteAllCacheDir_button.UseVisualStyleBackColor = true;
            this.DeleteAllCacheDir_button.Click += new System.EventHandler(this.DeleteAllCacheDir_button_Click);
            // 
            // KillProc_button
            // 
            this.KillProc_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KillProc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KillProc_button.Location = new System.Drawing.Point(812, 12);
            this.KillProc_button.Name = "KillProc_button";
            this.KillProc_button.Size = new System.Drawing.Size(168, 23);
            this.KillProc_button.TabIndex = 3;
            this.KillProc_button.Text = "Убить процессы 1с";
            this.KillProc_button.UseVisualStyleBackColor = true;
            this.KillProc_button.Click += new System.EventHandler(this.KillProc_button_Click);
            // 
            // ServiceState32_label
            // 
            this.ServiceState32_label.AutoSize = true;
            this.ServiceState32_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceState32_label.Location = new System.Drawing.Point(6, 18);
            this.ServiceState32_label.Name = "ServiceState32_label";
            this.ServiceState32_label.Size = new System.Drawing.Size(108, 16);
            this.ServiceState32_label.TabIndex = 5;
            this.ServiceState32_label.Text = "Статус службы:";
            // 
            // ServiceState64_label
            // 
            this.ServiceState64_label.AutoSize = true;
            this.ServiceState64_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceState64_label.Location = new System.Drawing.Point(6, 18);
            this.ServiceState64_label.Name = "ServiceState64_label";
            this.ServiceState64_label.Size = new System.Drawing.Size(108, 16);
            this.ServiceState64_label.TabIndex = 6;
            this.ServiceState64_label.Text = "Статус службы:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 490);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Cache_dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кеш";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UpdateService_button);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Службы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UpdateService_button
            // 
            this.UpdateService_button.Location = new System.Drawing.Point(6, 6);
            this.UpdateService_button.Name = "UpdateService_button";
            this.UpdateService_button.Size = new System.Drawing.Size(120, 23);
            this.UpdateService_button.TabIndex = 11;
            this.UpdateService_button.Text = "Обновить";
            this.UpdateService_button.UseVisualStyleBackColor = true;
            this.UpdateService_button.Click += new System.EventHandler(this.UpdateService_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ServiceUpdateVer64_button);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ServiceVer64_comboBox);
            this.groupBox2.Controls.Add(this.ServiceDebug64_button);
            this.groupBox2.Controls.Add(this.ServiceRestart64_button);
            this.groupBox2.Controls.Add(this.ServiceState64_label);
            this.groupBox2.Controls.Add(this.ServiceReg64_label);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(948, 277);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "64";
            // 
            // ServiceUpdateVer64_button
            // 
            this.ServiceUpdateVer64_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceUpdateVer64_button.Location = new System.Drawing.Point(310, 89);
            this.ServiceUpdateVer64_button.Name = "ServiceUpdateVer64_button";
            this.ServiceUpdateVer64_button.Size = new System.Drawing.Size(86, 23);
            this.ServiceUpdateVer64_button.TabIndex = 17;
            this.ServiceUpdateVer64_button.Text = "Изменить";
            this.ServiceUpdateVer64_button.UseVisualStyleBackColor = true;
            this.ServiceUpdateVer64_button.Click += new System.EventHandler(this.ServiceUpdateVer64_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(229, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Версии:";
            // 
            // ServiceVer64_comboBox
            // 
            this.ServiceVer64_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceVer64_comboBox.FormattingEnabled = true;
            this.ServiceVer64_comboBox.Location = new System.Drawing.Point(293, 56);
            this.ServiceVer64_comboBox.Name = "ServiceVer64_comboBox";
            this.ServiceVer64_comboBox.Size = new System.Drawing.Size(121, 24);
            this.ServiceVer64_comboBox.TabIndex = 15;
            // 
            // ServiceDebug64_button
            // 
            this.ServiceDebug64_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceDebug64_button.Location = new System.Drawing.Point(9, 54);
            this.ServiceDebug64_button.Name = "ServiceDebug64_button";
            this.ServiceDebug64_button.Size = new System.Drawing.Size(168, 26);
            this.ServiceDebug64_button.TabIndex = 12;
            this.ServiceDebug64_button.Text = "Дописать \"-debug\"";
            this.ServiceDebug64_button.UseVisualStyleBackColor = true;
            this.ServiceDebug64_button.Click += new System.EventHandler(this.ServiceDebug64_button_Click);
            // 
            // ServiceRestart64_button
            // 
            this.ServiceRestart64_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceRestart64_button.Location = new System.Drawing.Point(9, 87);
            this.ServiceRestart64_button.Name = "ServiceRestart64_button";
            this.ServiceRestart64_button.Size = new System.Drawing.Size(168, 26);
            this.ServiceRestart64_button.TabIndex = 13;
            this.ServiceRestart64_button.Text = "Перезапустить";
            this.ServiceRestart64_button.UseVisualStyleBackColor = true;
            this.ServiceRestart64_button.Click += new System.EventHandler(this.ServiceRestart64_button_Click);
            // 
            // ServiceReg64_label
            // 
            this.ServiceReg64_label.AutoSize = true;
            this.ServiceReg64_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceReg64_label.Location = new System.Drawing.Point(6, 34);
            this.ServiceReg64_label.Name = "ServiceReg64_label";
            this.ServiceReg64_label.Size = new System.Drawing.Size(57, 16);
            this.ServiceReg64_label.TabIndex = 8;
            this.ServiceReg64_label.Text = "Реестр:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ServiceUpdateVer32_button);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ServiceVer32_comboBox);
            this.groupBox1.Controls.Add(this.ServiceRestart32_button);
            this.groupBox1.Controls.Add(this.ServiceState32_label);
            this.groupBox1.Controls.Add(this.ServiceDebug32_button);
            this.groupBox1.Controls.Add(this.ServiceReg32_label);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 233);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "32";
            // 
            // ServiceUpdateVer32_button
            // 
            this.ServiceUpdateVer32_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceUpdateVer32_button.Location = new System.Drawing.Point(307, 89);
            this.ServiceUpdateVer32_button.Name = "ServiceUpdateVer32_button";
            this.ServiceUpdateVer32_button.Size = new System.Drawing.Size(86, 23);
            this.ServiceUpdateVer32_button.TabIndex = 16;
            this.ServiceUpdateVer32_button.Text = "Изменить";
            this.ServiceUpdateVer32_button.UseVisualStyleBackColor = true;
            this.ServiceUpdateVer32_button.Click += new System.EventHandler(this.ServiceUpdateVer32_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(226, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Версии:";
            // 
            // ServiceVer32_comboBox
            // 
            this.ServiceVer32_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceVer32_comboBox.FormattingEnabled = true;
            this.ServiceVer32_comboBox.Location = new System.Drawing.Point(290, 55);
            this.ServiceVer32_comboBox.Name = "ServiceVer32_comboBox";
            this.ServiceVer32_comboBox.Size = new System.Drawing.Size(121, 24);
            this.ServiceVer32_comboBox.TabIndex = 14;
            // 
            // ServiceRestart32_button
            // 
            this.ServiceRestart32_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceRestart32_button.Location = new System.Drawing.Point(6, 87);
            this.ServiceRestart32_button.Name = "ServiceRestart32_button";
            this.ServiceRestart32_button.Size = new System.Drawing.Size(168, 26);
            this.ServiceRestart32_button.TabIndex = 14;
            this.ServiceRestart32_button.Text = "Перезапустить";
            this.ServiceRestart32_button.UseVisualStyleBackColor = true;
            this.ServiceRestart32_button.Click += new System.EventHandler(this.ServiceRestart32_button_Click);
            // 
            // ServiceDebug32_button
            // 
            this.ServiceDebug32_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceDebug32_button.Location = new System.Drawing.Point(6, 52);
            this.ServiceDebug32_button.Name = "ServiceDebug32_button";
            this.ServiceDebug32_button.Size = new System.Drawing.Size(168, 28);
            this.ServiceDebug32_button.TabIndex = 13;
            this.ServiceDebug32_button.Text = "Дописать \"-debug\"";
            this.ServiceDebug32_button.UseVisualStyleBackColor = true;
            this.ServiceDebug32_button.Click += new System.EventHandler(this.ServiceDebug32_button_Click);
            // 
            // ServiceReg32_label
            // 
            this.ServiceReg32_label.AutoSize = true;
            this.ServiceReg32_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceReg32_label.Location = new System.Drawing.Point(6, 34);
            this.ServiceReg32_label.Name = "ServiceReg32_label";
            this.ServiceReg32_label.Size = new System.Drawing.Size(57, 16);
            this.ServiceReg32_label.TabIndex = 7;
            this.ServiceReg32_label.Text = "Реестр:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(333, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Аргумент командной строки для удаления всего сразу: FullClear";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(992, 543);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.KillProc_button);
            this.Controls.Add(this.DeleteAllCacheDir_button);
            this.Controls.Add(this.UpdateCacheDir_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с кэшем 1с v08.11.2025";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cache_dataGridView)).EndInit();
            this.Cache_contextMenuStrip.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Cache_dataGridView;
        private System.Windows.Forms.Button UpdateCacheDir_button;
        private System.Windows.Forms.Button DeleteAllCacheDir_button;
        private System.Windows.Forms.ContextMenuStrip Cache_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button KillProc_button;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label ServiceState32_label;
        private System.Windows.Forms.Label ServiceState64_label;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directory;
        private System.Windows.Forms.Label ServiceReg64_label;
        private System.Windows.Forms.Label ServiceReg32_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UpdateService_button;
        private System.Windows.Forms.Button ServiceDebug64_button;
        private System.Windows.Forms.Button ServiceDebug32_button;
        private System.Windows.Forms.Button ServiceRestart32_button;
        private System.Windows.Forms.Button ServiceRestart64_button;
        private System.Windows.Forms.ComboBox ServiceVer64_comboBox;
        private System.Windows.Forms.ComboBox ServiceVer32_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ServiceUpdateVer64_button;
        private System.Windows.Forms.Button ServiceUpdateVer32_button;
    }
}


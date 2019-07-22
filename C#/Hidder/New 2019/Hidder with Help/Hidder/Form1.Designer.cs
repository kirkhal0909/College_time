namespace Hidder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageHide = new System.Windows.Forms.TabPage();
            this.panelHide = new System.Windows.Forms.Panel();
            this.labelMainFile = new System.Windows.Forms.Label();
            this.radioButtonHideFolder = new System.Windows.Forms.RadioButton();
            this.textBoxPasswordToHide = new System.Windows.Forms.TextBox();
            this.radioButtonHideFile = new System.Windows.Forms.RadioButton();
            this.checkBoxHideWithPassword = new System.Windows.Forms.CheckBox();
            this.buttonProcessHide = new System.Windows.Forms.Button();
            this.textBoxMainPath = new System.Windows.Forms.TextBox();
            this.textBoxHideFiles = new System.Windows.Forms.TextBox();
            this.labelHideFiles = new System.Windows.Forms.Label();
            this.buttonChangeHidePath = new System.Windows.Forms.Button();
            this.buttonChangeMainPath = new System.Windows.Forms.Button();
            this.panelStatusHide = new System.Windows.Forms.Panel();
            this.progressBarHide = new System.Windows.Forms.ProgressBar();
            this.labelStatusSignHide = new System.Windows.Forms.Label();
            this.labelStatusHide = new System.Windows.Forms.Label();
            this.tabPageUnhide = new System.Windows.Forms.TabPage();
            this.panelStatusExtract = new System.Windows.Forms.Panel();
            this.progressBarExtract = new System.Windows.Forms.ProgressBar();
            this.labelStatusSign = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelExtract = new System.Windows.Forms.Panel();
            this.labelFile = new System.Windows.Forms.Label();
            this.labelExtract = new System.Windows.Forms.Label();
            this.textBoxPasswordToExtract = new System.Windows.Forms.TextBox();
            this.textBoxPathExtract = new System.Windows.Forms.TextBox();
            this.checkBoxExtractWithPassword = new System.Windows.Forms.CheckBox();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonWhereExtract = new System.Windows.Forms.Button();
            this.buttonPathToFile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabControlMain.SuspendLayout();
            this.tabPageHide.SuspendLayout();
            this.panelHide.SuspendLayout();
            this.panelStatusHide.SuspendLayout();
            this.tabPageUnhide.SuspendLayout();
            this.panelStatusExtract.SuspendLayout();
            this.panelExtract.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageHide);
            this.tabControlMain.Controls.Add(this.tabPageUnhide);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlMain.Location = new System.Drawing.Point(1, 30);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(552, 359);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageHide
            // 
            this.tabPageHide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageHide.Controls.Add(this.panelHide);
            this.tabPageHide.Controls.Add(this.panelStatusHide);
            this.tabPageHide.Location = new System.Drawing.Point(4, 34);
            this.tabPageHide.Name = "tabPageHide";
            this.tabPageHide.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHide.Size = new System.Drawing.Size(544, 321);
            this.tabPageHide.TabIndex = 0;
            this.tabPageHide.Text = "Спрятать файлы";
            this.tabPageHide.Click += new System.EventHandler(this.tabPageHide_Click);
            // 
            // panelHide
            // 
            this.panelHide.Controls.Add(this.labelMainFile);
            this.panelHide.Controls.Add(this.radioButtonHideFolder);
            this.panelHide.Controls.Add(this.textBoxPasswordToHide);
            this.panelHide.Controls.Add(this.radioButtonHideFile);
            this.panelHide.Controls.Add(this.checkBoxHideWithPassword);
            this.panelHide.Controls.Add(this.buttonProcessHide);
            this.panelHide.Controls.Add(this.textBoxMainPath);
            this.panelHide.Controls.Add(this.textBoxHideFiles);
            this.panelHide.Controls.Add(this.labelHideFiles);
            this.panelHide.Controls.Add(this.buttonChangeHidePath);
            this.panelHide.Controls.Add(this.buttonChangeMainPath);
            this.panelHide.Location = new System.Drawing.Point(0, 0);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(547, 251);
            this.panelHide.TabIndex = 27;
            // 
            // labelMainFile
            // 
            this.labelMainFile.AutoSize = true;
            this.labelMainFile.Location = new System.Drawing.Point(8, 7);
            this.labelMainFile.Name = "labelMainFile";
            this.labelMainFile.Size = new System.Drawing.Size(165, 25);
            this.labelMainFile.TabIndex = 1;
            this.labelMainFile.Text = "Основной файл:";
            // 
            // radioButtonHideFolder
            // 
            this.radioButtonHideFolder.AutoSize = true;
            this.radioButtonHideFolder.Location = new System.Drawing.Point(155, 97);
            this.radioButtonHideFolder.Name = "radioButtonHideFolder";
            this.radioButtonHideFolder.Size = new System.Drawing.Size(197, 29);
            this.radioButtonHideFolder.TabIndex = 7;
            this.radioButtonHideFolder.Text = "Папку с файлами";
            this.radioButtonHideFolder.UseVisualStyleBackColor = true;
            this.radioButtonHideFolder.CheckedChanged += new System.EventHandler(this.radioButtonHideFolder_CheckedChanged);
            // 
            // textBoxPasswordToHide
            // 
            this.textBoxPasswordToHide.Enabled = false;
            this.textBoxPasswordToHide.Location = new System.Drawing.Point(13, 209);
            this.textBoxPasswordToHide.Name = "textBoxPasswordToHide";
            this.textBoxPasswordToHide.PasswordChar = '*';
            this.textBoxPasswordToHide.Size = new System.Drawing.Size(283, 30);
            this.textBoxPasswordToHide.TabIndex = 11;
            // 
            // radioButtonHideFile
            // 
            this.radioButtonHideFile.AutoSize = true;
            this.radioButtonHideFile.Checked = true;
            this.radioButtonHideFile.Location = new System.Drawing.Point(13, 97);
            this.radioButtonHideFile.Name = "radioButtonHideFile";
            this.radioButtonHideFile.Size = new System.Drawing.Size(85, 29);
            this.radioButtonHideFile.TabIndex = 6;
            this.radioButtonHideFile.TabStop = true;
            this.radioButtonHideFile.Text = "Файл";
            this.radioButtonHideFile.UseVisualStyleBackColor = true;
            this.radioButtonHideFile.CheckedChanged += new System.EventHandler(this.radioButtonHideFolder_CheckedChanged);
            // 
            // checkBoxHideWithPassword
            // 
            this.checkBoxHideWithPassword.AutoSize = true;
            this.checkBoxHideWithPassword.Location = new System.Drawing.Point(14, 174);
            this.checkBoxHideWithPassword.Name = "checkBoxHideWithPassword";
            this.checkBoxHideWithPassword.Size = new System.Drawing.Size(283, 29);
            this.checkBoxHideWithPassword.TabIndex = 10;
            this.checkBoxHideWithPassword.Text = "Использовать свой пароль";
            this.checkBoxHideWithPassword.UseVisualStyleBackColor = true;
            this.checkBoxHideWithPassword.CheckedChanged += new System.EventHandler(this.checkBoxHideWithPassword_CheckedChanged);
            // 
            // buttonProcessHide
            // 
            this.buttonProcessHide.Location = new System.Drawing.Point(340, 174);
            this.buttonProcessHide.Name = "buttonProcessHide";
            this.buttonProcessHide.Size = new System.Drawing.Size(194, 69);
            this.buttonProcessHide.TabIndex = 8;
            this.buttonProcessHide.Text = "Спрятать";
            this.buttonProcessHide.UseVisualStyleBackColor = true;
            this.buttonProcessHide.Click += new System.EventHandler(this.buttonProcessHide_Click);
            // 
            // textBoxMainPath
            // 
            this.textBoxMainPath.Location = new System.Drawing.Point(13, 36);
            this.textBoxMainPath.Name = "textBoxMainPath";
            this.textBoxMainPath.Size = new System.Drawing.Size(482, 30);
            this.textBoxMainPath.TabIndex = 2;
            // 
            // textBoxHideFiles
            // 
            this.textBoxHideFiles.Location = new System.Drawing.Point(13, 132);
            this.textBoxHideFiles.Name = "textBoxHideFiles";
            this.textBoxHideFiles.Size = new System.Drawing.Size(482, 30);
            this.textBoxHideFiles.TabIndex = 5;
            // 
            // labelHideFiles
            // 
            this.labelHideFiles.AutoSize = true;
            this.labelHideFiles.Location = new System.Drawing.Point(8, 69);
            this.labelHideFiles.Name = "labelHideFiles";
            this.labelHideFiles.Size = new System.Drawing.Size(146, 25);
            this.labelHideFiles.TabIndex = 4;
            this.labelHideFiles.Text = "Что спрятать:";
            // 
            // buttonChangeHidePath
            // 
            this.buttonChangeHidePath.Location = new System.Drawing.Point(494, 132);
            this.buttonChangeHidePath.Name = "buttonChangeHidePath";
            this.buttonChangeHidePath.Size = new System.Drawing.Size(40, 30);
            this.buttonChangeHidePath.TabIndex = 3;
            this.buttonChangeHidePath.Text = "...";
            this.buttonChangeHidePath.UseVisualStyleBackColor = true;
            this.buttonChangeHidePath.Click += new System.EventHandler(this.buttonChangeHidePath_Click);
            // 
            // buttonChangeMainPath
            // 
            this.buttonChangeMainPath.Location = new System.Drawing.Point(494, 36);
            this.buttonChangeMainPath.Name = "buttonChangeMainPath";
            this.buttonChangeMainPath.Size = new System.Drawing.Size(40, 30);
            this.buttonChangeMainPath.TabIndex = 0;
            this.buttonChangeMainPath.Text = "...";
            this.buttonChangeMainPath.UseVisualStyleBackColor = true;
            this.buttonChangeMainPath.Click += new System.EventHandler(this.buttonChangeMainPath_Click);
            // 
            // panelStatusHide
            // 
            this.panelStatusHide.Controls.Add(this.progressBarHide);
            this.panelStatusHide.Controls.Add(this.labelStatusSignHide);
            this.panelStatusHide.Controls.Add(this.labelStatusHide);
            this.panelStatusHide.Enabled = false;
            this.panelStatusHide.Location = new System.Drawing.Point(0, 251);
            this.panelStatusHide.Name = "panelStatusHide";
            this.panelStatusHide.Size = new System.Drawing.Size(547, 73);
            this.panelStatusHide.TabIndex = 26;
            // 
            // progressBarHide
            // 
            this.progressBarHide.Location = new System.Drawing.Point(11, 38);
            this.progressBarHide.Name = "progressBarHide";
            this.progressBarHide.Size = new System.Drawing.Size(523, 23);
            this.progressBarHide.TabIndex = 24;
            // 
            // labelStatusSignHide
            // 
            this.labelStatusSignHide.AutoSize = true;
            this.labelStatusSignHide.Location = new System.Drawing.Point(6, 3);
            this.labelStatusSignHide.Name = "labelStatusSignHide";
            this.labelStatusSignHide.Size = new System.Drawing.Size(84, 25);
            this.labelStatusSignHide.TabIndex = 22;
            this.labelStatusSignHide.Text = "Статус:";
            // 
            // labelStatusHide
            // 
            this.labelStatusHide.AutoSize = true;
            this.labelStatusHide.Location = new System.Drawing.Point(90, 3);
            this.labelStatusHide.Name = "labelStatusHide";
            this.labelStatusHide.Size = new System.Drawing.Size(336, 25);
            this.labelStatusHide.TabIndex = 23;
            this.labelStatusHide.Text = "ожидание действий пользователя";
            // 
            // tabPageUnhide
            // 
            this.tabPageUnhide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageUnhide.Controls.Add(this.panelStatusExtract);
            this.tabPageUnhide.Controls.Add(this.panelExtract);
            this.tabPageUnhide.Location = new System.Drawing.Point(4, 34);
            this.tabPageUnhide.Name = "tabPageUnhide";
            this.tabPageUnhide.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUnhide.Size = new System.Drawing.Size(544, 321);
            this.tabPageUnhide.TabIndex = 1;
            this.tabPageUnhide.Text = "Распаковать спрятанные файлы";
            // 
            // panelStatusExtract
            // 
            this.panelStatusExtract.Controls.Add(this.progressBarExtract);
            this.panelStatusExtract.Controls.Add(this.labelStatusSign);
            this.panelStatusExtract.Controls.Add(this.labelStatus);
            this.panelStatusExtract.Enabled = false;
            this.panelStatusExtract.Location = new System.Drawing.Point(0, 251);
            this.panelStatusExtract.Name = "panelStatusExtract";
            this.panelStatusExtract.Size = new System.Drawing.Size(547, 73);
            this.panelStatusExtract.TabIndex = 25;
            // 
            // progressBarExtract
            // 
            this.progressBarExtract.Location = new System.Drawing.Point(11, 38);
            this.progressBarExtract.Name = "progressBarExtract";
            this.progressBarExtract.Size = new System.Drawing.Size(523, 23);
            this.progressBarExtract.TabIndex = 24;
            // 
            // labelStatusSign
            // 
            this.labelStatusSign.AutoSize = true;
            this.labelStatusSign.Location = new System.Drawing.Point(6, 3);
            this.labelStatusSign.Name = "labelStatusSign";
            this.labelStatusSign.Size = new System.Drawing.Size(84, 25);
            this.labelStatusSign.TabIndex = 22;
            this.labelStatusSign.Text = "Статус:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(90, 3);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(336, 25);
            this.labelStatus.TabIndex = 23;
            this.labelStatus.Text = "ожидание действий пользователя";
            // 
            // panelExtract
            // 
            this.panelExtract.Controls.Add(this.labelFile);
            this.panelExtract.Controls.Add(this.labelExtract);
            this.panelExtract.Controls.Add(this.textBoxPasswordToExtract);
            this.panelExtract.Controls.Add(this.textBoxPathExtract);
            this.panelExtract.Controls.Add(this.checkBoxExtractWithPassword);
            this.panelExtract.Controls.Add(this.buttonExtract);
            this.panelExtract.Controls.Add(this.textBoxFile);
            this.panelExtract.Controls.Add(this.buttonWhereExtract);
            this.panelExtract.Controls.Add(this.buttonPathToFile);
            this.panelExtract.Location = new System.Drawing.Point(0, 0);
            this.panelExtract.Name = "panelExtract";
            this.panelExtract.Size = new System.Drawing.Size(547, 251);
            this.panelExtract.TabIndex = 24;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(8, 7);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(70, 25);
            this.labelFile.TabIndex = 17;
            this.labelFile.Text = "Файл:";
            // 
            // labelExtract
            // 
            this.labelExtract.AutoSize = true;
            this.labelExtract.Location = new System.Drawing.Point(8, 104);
            this.labelExtract.Name = "labelExtract";
            this.labelExtract.Size = new System.Drawing.Size(369, 25);
            this.labelExtract.TabIndex = 14;
            this.labelExtract.Text = "Куда распаковать спрятанные файлы:";
            // 
            // textBoxPasswordToExtract
            // 
            this.textBoxPasswordToExtract.Enabled = false;
            this.textBoxPasswordToExtract.Location = new System.Drawing.Point(13, 209);
            this.textBoxPasswordToExtract.Name = "textBoxPasswordToExtract";
            this.textBoxPasswordToExtract.PasswordChar = '*';
            this.textBoxPasswordToExtract.Size = new System.Drawing.Size(283, 30);
            this.textBoxPasswordToExtract.TabIndex = 21;
            // 
            // textBoxPathExtract
            // 
            this.textBoxPathExtract.Location = new System.Drawing.Point(13, 132);
            this.textBoxPathExtract.Name = "textBoxPathExtract";
            this.textBoxPathExtract.Size = new System.Drawing.Size(482, 30);
            this.textBoxPathExtract.TabIndex = 15;
            // 
            // checkBoxExtractWithPassword
            // 
            this.checkBoxExtractWithPassword.AutoSize = true;
            this.checkBoxExtractWithPassword.Location = new System.Drawing.Point(14, 174);
            this.checkBoxExtractWithPassword.Name = "checkBoxExtractWithPassword";
            this.checkBoxExtractWithPassword.Size = new System.Drawing.Size(283, 29);
            this.checkBoxExtractWithPassword.TabIndex = 20;
            this.checkBoxExtractWithPassword.Text = "Использовать свой пароль";
            this.checkBoxExtractWithPassword.UseVisualStyleBackColor = true;
            this.checkBoxExtractWithPassword.CheckedChanged += new System.EventHandler(this.checkBoxExtractWithPassword_CheckedChanged);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(340, 174);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(194, 69);
            this.buttonExtract.TabIndex = 19;
            this.buttonExtract.Text = "Распаковать";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(13, 36);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(482, 30);
            this.textBoxFile.TabIndex = 18;
            // 
            // buttonWhereExtract
            // 
            this.buttonWhereExtract.Location = new System.Drawing.Point(494, 132);
            this.buttonWhereExtract.Name = "buttonWhereExtract";
            this.buttonWhereExtract.Size = new System.Drawing.Size(40, 30);
            this.buttonWhereExtract.TabIndex = 13;
            this.buttonWhereExtract.Text = "...";
            this.buttonWhereExtract.UseVisualStyleBackColor = true;
            this.buttonWhereExtract.Click += new System.EventHandler(this.buttonWhereExtract_Click);
            // 
            // buttonPathToFile
            // 
            this.buttonPathToFile.Location = new System.Drawing.Point(494, 36);
            this.buttonPathToFile.Name = "buttonPathToFile";
            this.buttonPathToFile.Size = new System.Drawing.Size(40, 30);
            this.buttonPathToFile.TabIndex = 16;
            this.buttonPathToFile.Text = "...";
            this.buttonPathToFile.UseVisualStyleBackColor = true;
            this.buttonPathToFile.Click += new System.EventHandler(this.buttonPathToFile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\KirKhal\\Desktop\\Downloads\\Debug-20190519T153651Z-001\\зап\\Hidder\\Hidder\\h" +
    "elp_.chm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(555, 391);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hidder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageHide.ResumeLayout(false);
            this.panelHide.ResumeLayout(false);
            this.panelHide.PerformLayout();
            this.panelStatusHide.ResumeLayout(false);
            this.panelStatusHide.PerformLayout();
            this.tabPageUnhide.ResumeLayout(false);
            this.panelStatusExtract.ResumeLayout(false);
            this.panelStatusExtract.PerformLayout();
            this.panelExtract.ResumeLayout(false);
            this.panelExtract.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageHide;
        private System.Windows.Forms.Button buttonChangeMainPath;
        private System.Windows.Forms.TabPage tabPageUnhide;
        private System.Windows.Forms.TextBox textBoxMainPath;
        private System.Windows.Forms.Label labelMainFile;
        private System.Windows.Forms.TextBox textBoxHideFiles;
        private System.Windows.Forms.Label labelHideFiles;
        private System.Windows.Forms.Button buttonChangeHidePath;
        private System.Windows.Forms.RadioButton radioButtonHideFile;
        private System.Windows.Forms.RadioButton radioButtonHideFolder;
        private System.Windows.Forms.Button buttonProcessHide;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonPathToFile;
        private System.Windows.Forms.TextBox textBoxPathExtract;
        private System.Windows.Forms.Label labelExtract;
        private System.Windows.Forms.Button buttonWhereExtract;
        private System.Windows.Forms.TextBox textBoxPasswordToHide;
        private System.Windows.Forms.CheckBox checkBoxHideWithPassword;
        private System.Windows.Forms.TextBox textBoxPasswordToExtract;
        private System.Windows.Forms.CheckBox checkBoxExtractWithPassword;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusSign;
        private System.Windows.Forms.Panel panelExtract;
        private System.Windows.Forms.Panel panelStatusExtract;
        private System.Windows.Forms.ProgressBar progressBarExtract;
        private System.Windows.Forms.Panel panelStatusHide;
        private System.Windows.Forms.ProgressBar progressBarHide;
        private System.Windows.Forms.Label labelStatusSignHide;
        private System.Windows.Forms.Label labelStatusHide;
        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}


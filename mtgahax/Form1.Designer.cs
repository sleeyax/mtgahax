namespace mtgahax
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClientMods = new System.Windows.Forms.TabPage();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonApplyMods = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableFeatureToggle = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableWotcAccess = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAlphaAccess = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableDemoMode = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableMythicQualifier = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableMythicOrange = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableDebugMode = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBrowseGameInstallationDir = new System.Windows.Forms.Button();
            this.textBoxGameInstallationDir = new System.Windows.Forms.TextBox();
            this.tabSessionHijacker = new System.Windows.Forms.TabPage();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.buttonLaunchGame = new System.Windows.Forms.Button();
            this.buttonCloseGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxYoutube = new System.Windows.Forms.PictureBox();
            this.pictureBoxGithub = new System.Windows.Forms.PictureBox();
            this.buttonRestoreBackup = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabClientMods.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClientMods);
            this.tabControl1.Controls.Add(this.tabSessionHijacker);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // tabClientMods
            // 
            this.tabClientMods.Controls.Add(this.labelStatus);
            this.tabClientMods.Controls.Add(this.buttonApplyMods);
            this.tabClientMods.Controls.Add(this.groupBox2);
            this.tabClientMods.Controls.Add(this.groupBox1);
            this.tabClientMods.Location = new System.Drawing.Point(4, 25);
            this.tabClientMods.Name = "tabClientMods";
            this.tabClientMods.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientMods.Size = new System.Drawing.Size(436, 360);
            this.tabClientMods.TabIndex = 0;
            this.tabClientMods.Text = "Client mods";
            this.tabClientMods.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(193, 304);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(52, 17);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "status";
            // 
            // buttonApplyMods
            // 
            this.buttonApplyMods.Location = new System.Drawing.Point(22, 294);
            this.buttonApplyMods.Name = "buttonApplyMods";
            this.buttonApplyMods.Size = new System.Drawing.Size(106, 37);
            this.buttonApplyMods.TabIndex = 3;
            this.buttonApplyMods.Text = "apply";
            this.buttonApplyMods.UseVisualStyleBackColor = true;
            this.buttonApplyMods.Click += new System.EventHandler(this.buttonApplyMods_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxEnableFeatureToggle);
            this.groupBox2.Controls.Add(this.checkBoxEnableWotcAccess);
            this.groupBox2.Controls.Add(this.checkBoxEnableAlphaAccess);
            this.groupBox2.Controls.Add(this.checkBoxEnableDemoMode);
            this.groupBox2.Controls.Add(this.checkBoxEnableMythicQualifier);
            this.groupBox2.Controls.Add(this.checkBoxEnableMythicOrange);
            this.groupBox2.Controls.Add(this.checkBoxEnableDebugMode);
            this.groupBox2.Location = new System.Drawing.Point(6, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 152);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2 - modify acount roles";
            // 
            // checkBoxEnableFeatureToggle
            // 
            this.checkBoxEnableFeatureToggle.AutoSize = true;
            this.checkBoxEnableFeatureToggle.Location = new System.Drawing.Point(258, 77);
            this.checkBoxEnableFeatureToggle.Name = "checkBoxEnableFeatureToggle";
            this.checkBoxEnableFeatureToggle.Size = new System.Drawing.Size(119, 21);
            this.checkBoxEnableFeatureToggle.TabIndex = 6;
            this.checkBoxEnableFeatureToggle.Text = "other features";
            this.checkBoxEnableFeatureToggle.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableWotcAccess
            // 
            this.checkBoxEnableWotcAccess.AutoSize = true;
            this.checkBoxEnableWotcAccess.Location = new System.Drawing.Point(133, 77);
            this.checkBoxEnableWotcAccess.Name = "checkBoxEnableWotcAccess";
            this.checkBoxEnableWotcAccess.Size = new System.Drawing.Size(106, 21);
            this.checkBoxEnableWotcAccess.TabIndex = 5;
            this.checkBoxEnableWotcAccess.Text = "wotc access";
            this.toolTip.SetToolTip(this.checkBoxEnableWotcAccess, "wotc admin access");
            this.checkBoxEnableWotcAccess.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableAlphaAccess
            // 
            this.checkBoxEnableAlphaAccess.AutoSize = true;
            this.checkBoxEnableAlphaAccess.Location = new System.Drawing.Point(18, 77);
            this.checkBoxEnableAlphaAccess.Name = "checkBoxEnableAlphaAccess";
            this.checkBoxEnableAlphaAccess.Size = new System.Drawing.Size(108, 21);
            this.checkBoxEnableAlphaAccess.TabIndex = 4;
            this.checkBoxEnableAlphaAccess.Text = "alpha player";
            this.checkBoxEnableAlphaAccess.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableDemoMode
            // 
            this.checkBoxEnableDemoMode.AutoSize = true;
            this.checkBoxEnableDemoMode.Location = new System.Drawing.Point(18, 116);
            this.checkBoxEnableDemoMode.Name = "checkBoxEnableDemoMode";
            this.checkBoxEnableDemoMode.Size = new System.Drawing.Size(104, 21);
            this.checkBoxEnableDemoMode.TabIndex = 4;
            this.checkBoxEnableDemoMode.Text = "demo mode";
            this.checkBoxEnableDemoMode.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableMythicQualifier
            // 
            this.checkBoxEnableMythicQualifier.AutoSize = true;
            this.checkBoxEnableMythicQualifier.Location = new System.Drawing.Point(258, 41);
            this.checkBoxEnableMythicQualifier.Name = "checkBoxEnableMythicQualifier";
            this.checkBoxEnableMythicQualifier.Size = new System.Drawing.Size(124, 21);
            this.checkBoxEnableMythicQualifier.TabIndex = 3;
            this.checkBoxEnableMythicQualifier.Text = "mythic qualifier";
            this.checkBoxEnableMythicQualifier.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableMythicOrange
            // 
            this.checkBoxEnableMythicOrange.AutoSize = true;
            this.checkBoxEnableMythicOrange.Location = new System.Drawing.Point(133, 41);
            this.checkBoxEnableMythicOrange.Name = "checkBoxEnableMythicOrange";
            this.checkBoxEnableMythicOrange.Size = new System.Drawing.Size(119, 21);
            this.checkBoxEnableMythicOrange.TabIndex = 3;
            this.checkBoxEnableMythicOrange.Text = "mythic orange";
            this.toolTip.SetToolTip(this.checkBoxEnableMythicOrange, "wotc team member access");
            this.checkBoxEnableMythicOrange.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableDebugMode
            // 
            this.checkBoxEnableDebugMode.AutoSize = true;
            this.checkBoxEnableDebugMode.Location = new System.Drawing.Point(18, 41);
            this.checkBoxEnableDebugMode.Name = "checkBoxEnableDebugMode";
            this.checkBoxEnableDebugMode.Size = new System.Drawing.Size(109, 21);
            this.checkBoxEnableDebugMode.TabIndex = 0;
            this.checkBoxEnableDebugMode.Text = "debug mode";
            this.checkBoxEnableDebugMode.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBrowseGameInstallationDir);
            this.groupBox1.Controls.Add(this.textBoxGameInstallationDir);
            this.groupBox1.Location = new System.Drawing.Point(8, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 - select game installation directory";
            // 
            // buttonBrowseGameInstallationDir
            // 
            this.buttonBrowseGameInstallationDir.Location = new System.Drawing.Point(288, 28);
            this.buttonBrowseGameInstallationDir.Name = "buttonBrowseGameInstallationDir";
            this.buttonBrowseGameInstallationDir.Size = new System.Drawing.Size(76, 24);
            this.buttonBrowseGameInstallationDir.TabIndex = 1;
            this.buttonBrowseGameInstallationDir.Text = "browse";
            this.buttonBrowseGameInstallationDir.UseVisualStyleBackColor = true;
            this.buttonBrowseGameInstallationDir.Click += new System.EventHandler(this.buttonBrowseGameInstallationDir_Click);
            // 
            // textBoxGameInstallationDir
            // 
            this.textBoxGameInstallationDir.Location = new System.Drawing.Point(18, 29);
            this.textBoxGameInstallationDir.Name = "textBoxGameInstallationDir";
            this.textBoxGameInstallationDir.Size = new System.Drawing.Size(264, 22);
            this.textBoxGameInstallationDir.TabIndex = 0;
            // 
            // tabSessionHijacker
            // 
            this.tabSessionHijacker.Location = new System.Drawing.Point(4, 25);
            this.tabSessionHijacker.Name = "tabSessionHijacker";
            this.tabSessionHijacker.Padding = new System.Windows.Forms.Padding(3);
            this.tabSessionHijacker.Size = new System.Drawing.Size(436, 360);
            this.tabSessionHijacker.TabIndex = 1;
            this.tabSessionHijacker.Text = "Session hijacker";
            this.tabSessionHijacker.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.buttonRestoreBackup);
            this.tabPageSettings.Controls.Add(this.pictureBoxGithub);
            this.tabPageSettings.Controls.Add(this.pictureBoxYoutube);
            this.tabPageSettings.Controls.Add(this.label1);
            this.tabPageSettings.Controls.Add(this.buttonCloseGame);
            this.tabPageSettings.Controls.Add(this.buttonLaunchGame);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(436, 360);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // buttonLaunchGame
            // 
            this.buttonLaunchGame.Location = new System.Drawing.Point(18, 28);
            this.buttonLaunchGame.Name = "buttonLaunchGame";
            this.buttonLaunchGame.Size = new System.Drawing.Size(102, 37);
            this.buttonLaunchGame.TabIndex = 5;
            this.buttonLaunchGame.Text = "launch game";
            this.buttonLaunchGame.UseVisualStyleBackColor = true;
            this.buttonLaunchGame.Click += new System.EventHandler(this.buttonLaunchGame_Click);
            // 
            // buttonCloseGame
            // 
            this.buttonCloseGame.Location = new System.Drawing.Point(145, 28);
            this.buttonCloseGame.Name = "buttonCloseGame";
            this.buttonCloseGame.Size = new System.Drawing.Size(102, 37);
            this.buttonCloseGame.TabIndex = 6;
            this.buttonCloseGame.Text = "close game";
            this.buttonCloseGame.UseVisualStyleBackColor = true;
            this.buttonCloseGame.Click += new System.EventHandler(this.buttonCloseGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Coded by Sleeyax";
            // 
            // pictureBoxYoutube
            // 
            this.pictureBoxYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxYoutube.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxYoutube.Image")));
            this.pictureBoxYoutube.Location = new System.Drawing.Point(294, 299);
            this.pictureBoxYoutube.Name = "pictureBoxYoutube";
            this.pictureBoxYoutube.Size = new System.Drawing.Size(46, 46);
            this.pictureBoxYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxYoutube.TabIndex = 8;
            this.pictureBoxYoutube.TabStop = false;
            this.pictureBoxYoutube.Click += new System.EventHandler(this.pictureBoxYoutube_Click);
            // 
            // pictureBoxGithub
            // 
            this.pictureBoxGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGithub.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGithub.Image")));
            this.pictureBoxGithub.Location = new System.Drawing.Point(220, 299);
            this.pictureBoxGithub.Name = "pictureBoxGithub";
            this.pictureBoxGithub.Size = new System.Drawing.Size(54, 46);
            this.pictureBoxGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGithub.TabIndex = 9;
            this.pictureBoxGithub.TabStop = false;
            this.pictureBoxGithub.Click += new System.EventHandler(this.pictureBoxGithub_Click);
            // 
            // buttonRestoreBackup
            // 
            this.buttonRestoreBackup.Location = new System.Drawing.Point(272, 28);
            this.buttonRestoreBackup.Name = "buttonRestoreBackup";
            this.buttonRestoreBackup.Size = new System.Drawing.Size(115, 37);
            this.buttonRestoreBackup.TabIndex = 10;
            this.buttonRestoreBackup.Text = "restore backup";
            this.buttonRestoreBackup.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 389);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mtgahax";
            this.tabControl1.ResumeLayout(false);
            this.tabClientMods.ResumeLayout(false);
            this.tabClientMods.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGithub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClientMods;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBrowseGameInstallationDir;
        private System.Windows.Forms.TextBox textBoxGameInstallationDir;
        private System.Windows.Forms.CheckBox checkBoxEnableDebugMode;
        private System.Windows.Forms.TabPage tabSessionHijacker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxEnableMythicOrange;
        private System.Windows.Forms.CheckBox checkBoxEnableMythicQualifier;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkBoxEnableAlphaAccess;
        private System.Windows.Forms.CheckBox checkBoxEnableDemoMode;
        private System.Windows.Forms.CheckBox checkBoxEnableWotcAccess;
        private System.Windows.Forms.CheckBox checkBoxEnableFeatureToggle;
        private System.Windows.Forms.Button buttonApplyMods;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Button buttonCloseGame;
        private System.Windows.Forms.Button buttonLaunchGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxGithub;
        private System.Windows.Forms.PictureBox pictureBoxYoutube;
        private System.Windows.Forms.Button buttonRestoreBackup;
    }
}


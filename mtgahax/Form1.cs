using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mtgahax.Patches.Roles;

namespace mtgahax
{
    public partial class MainWindow : Form
    {
        private string _gameDir;
        private string _targetAssembly;

        public MainWindow()
        {
            InitializeComponent();
            labelStatus.Hide();
        }

        private void ShowSuccessStatus(string text)
        {
            labelStatus.Show();
            labelStatus.Text = text;
            labelStatus.ForeColor = Color.LimeGreen;
        }

        private void ShowErrorStatus(string text)
        {
            labelStatus.Show();
            labelStatus.Text = text;
            labelStatus.ForeColor = Color.Red;
        }

        private void ShowDefaultStatus(string text)
        {
            labelStatus.Show();
            labelStatus.Text = text;
            labelStatus.ForeColor = Color.Black;
        }

        private void buttonBrowseGameInstallationDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _gameDir = folderBrowserDialog1.SelectedPath;
            }

            textBoxGameInstallationDir.Text = _gameDir;
        }

        private async void buttonApplyMods_Click(object sender, EventArgs e)
        {
            if (textBoxGameInstallationDir.Text == "")
            {
                MessageBox.Show("Please enter your game installation directory first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string asm = Path.Combine(textBoxGameInstallationDir.Text, "MTGA_Data\\Managed\\Assembly-CSharp.dll");
            if (!File.Exists(asm))
            {
                MessageBox.Show("Invalid game installation directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _targetAssembly = asm;

            List<string> roles = new List<string>();

            if (checkBoxEnableAlphaAccess.Checked)
                roles.Add(RoleType.MDN_ALPHA);
            if (checkBoxEnableDebugMode.Checked)
                roles.Add(RoleType.DEBUG);
            if (checkBoxEnableDemoMode.Checked)
                roles.Add(RoleType.DEMO);
            if (checkBoxEnableFeatureToggle.Checked)
                roles.Add(RoleType.FEATURE_TOGGLE);
            if (checkBoxEnableMythicOrange.Checked)
                roles.Add(RoleType.MYTHIC_ORANGE);
            if (checkBoxEnableWotcAccess.Checked)
                roles.Add(RoleType.WOTC_ACCESS);
            if (checkBoxEnableMythicQualifier.Checked)
                roles.Add(RoleType.INVITATIONAL_QUALIFIED);

            try
            {
                ShowDefaultStatus("Patching...");
                RolesPatch rolesPatch = new RolesPatch(_targetAssembly);
                await Task.Run(() =>
                {
                    rolesPatch.Apply(roles);
                });
                ShowSuccessStatus("Game patched!");
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown error occurred while patching your game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowErrorStatus("Patching error");
            }
           
        }

        private void buttonLaunchGame_Click(object sender, EventArgs e)
        {
            string game = Path.Combine(textBoxGameInstallationDir.Text, "MTGA.exe");
            try
            {
                Process.Start(game);
                ShowDefaultStatus("Game launched!");
            }
            catch (Exception)
            {
                MessageBox.Show($"Failed to launch game. {game} not found. Did you select your game's installation directory?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowErrorStatus("Failed to launch game");
            }

        }

        private void buttonCloseGame_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("MTGA"))
            {
                process.Kill();
            }
        }

        private void buttonRestoreBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string backupAssembly = Path.Combine(Path.GetDirectoryName(_targetAssembly), "Assembly-CSharp.dll.bak");

                if (File.Exists(backupAssembly))
                {
                    File.Delete(_targetAssembly);
                    File.Move(backupAssembly, _targetAssembly);
                }

                MessageBox.Show("Backup restored successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to restore backup. Something went wrong :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/sleeyax");
        }

        private void pictureBoxYoutube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCa4m-l2cMD_ha7Rqh_Xgw5A");
        }
    }
}

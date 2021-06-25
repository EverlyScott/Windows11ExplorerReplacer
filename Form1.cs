using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Windows11ExplorerReplacer
{
    public partial class form1 : Form
    {

        Version currentVersion = Version.Parse("1.0.0");
        
        public form1()
        {
            //Check for updates
            WebClient client = new WebClient();
            string latestVersion = client.DownloadString("https://cdn.scribblenerd.com/latestversions/windows11explorerreplacer.txt");
            if (Version.Parse(latestVersion) > currentVersion)
            {
                DialogResult = MessageBox.Show("There is an update available. Would you like to update?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    Process.Start("explorer.exe", "https://github.com/ScribbleNerd/Windows11ExplorerReplacer/releases/latest");
                }
            }

            InitializeComponent();

            initInstalledText();
        }

        private void install_Click(object sender, EventArgs e)
        {
            Process install = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "install.bat",
                    UseShellExecute = true,
                    CreateNoWindow = true
                }
            };
            install.Start();
            Properties.Settings.Default.installed = true;
            Properties.Settings.Default.Save();
            initInstalledText();
        }

        private void uninstall_Click(object sender, EventArgs e)
        {
            Process uninstall = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "uninstall.bat",
                    UseShellExecute = true,
                    CreateNoWindow = true
                }
            };
            uninstall.Start();
            Properties.Settings.Default.installed = false;
            Properties.Settings.Default.Save();
            initInstalledText();
        }

        private void initInstalledText()
        {
            if (Properties.Settings.Default.installed)
            {
                installedText.Text = "Installed";
            }
            else
            {
                installedText.Text = "Not Installed";
            }
        }
    }
}

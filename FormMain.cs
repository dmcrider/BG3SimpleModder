using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BS3SimpleModder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();
            AppSettings.LoadSettings();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            pathsToolStripMenuItem.Click += ToolStripMenuItemSettingsPaths_Click;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (AppSettings.DataPath == "" || AppSettings.InstallPath == "")
            {
                MessageBox.Show("Please update the paths using the Settings menu.");
                UpdateMainPanelEnabled(false);
            }
        }

        private void ToolStripMenuItemSettingsPaths_Click(object sender, EventArgs e)
        {
            new FormSettings(this).ShowDialog();
        }

        public void UpdateMainPanelEnabled(bool isEnabled)
        {
            panelMain.Enabled = isEnabled;
        }
    }
}

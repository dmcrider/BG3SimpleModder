using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BG3SimpleModder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LarianExportTool.GetInstallPath();
            LarianExportTool.GetDataPath();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(LarianExportTool.DataPath == "" || LarianExportTool.InstallPath == "")
            {
                MessageBox.Show("One or more path was not found. Please update the paths using the Settings menu.");
            }
        }
    }
}

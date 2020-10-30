using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            txtLarianToolsPath.Text = LarianExportTool.InstallPath;
            txtDataPath.Text = LarianExportTool.DataPath;
        }

        private void BtnBrowserLarianTools_Click(object sender, EventArgs e)
        {
            txtLarianToolsPath.Text = BrowseForFolder(Environment.SpecialFolder.MyDocuments);
        }

        private void BtnDataPath_Click(object sender, EventArgs e)
        {
            var path = BrowseForFolder(Environment.SpecialFolder.ProgramFilesX86);

            if(!path.Contains(@"\common\Baldurs Gate 3\Data"))
            {
                MessageBox.Show("That's not a valid Data Path. The path must look like:\n\n...\\common\\Baldurs Gate 3\\Data");
            }
            else
            {
                txtDataPath.Text = path;
            }
        }

        private string BrowseForFolder(Environment.SpecialFolder root)
        {
            folderBrowserDialog.RootFolder = root;
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }

            folderBrowserDialog.SelectedPath = "";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Windows;
            return "";
        }
    }
}

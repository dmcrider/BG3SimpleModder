using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BG3SimpleModder
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            txtTools.Text = LarianExportTool.InstallPath;
            txtData.Text = LarianExportTool.DataPath;
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

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Tag.ToString())
            {
                case "tools":
                    txtTools.Text = BrowseForFolder(Environment.SpecialFolder.MyDocuments);
                    break;
                case "data":
                    txtData.Text = BrowseForFolder(Environment.SpecialFolder.ProgramFilesX86);
                    break;
                default:
                    return;
            }
        }
    }
}

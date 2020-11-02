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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace BS3SimpleModder
{
    public partial class FormSettings : Form
    {
        private readonly FormMain formMain;

        public FormSettings(FormMain parentForm)
        {
            InitializeComponent();
            CenterToParent();
            formMain = parentForm;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            txtTools.Text = AppSettings.InstallPath;
            txtData.Text = AppSettings.DataPath;
            txtBackup.Text = GetBackupLocation();
        }

        private string BrowseForFolder(string rootPath, string currentSelection)
        {
            var dialog = new CommonOpenFileDialog()
            {
                InitialDirectory = rootPath,
                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var result = dialog.FileName;
                dialog.Dispose();
                return result;
            }

            dialog.Dispose();
            return currentSelection;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag.ToString())
            {
                case "tools":
                    txtTools.Text = BrowseForFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), txtTools.Text);
                    break;
                case "data":
                    txtData.Text = BrowseForFolder(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), txtData.Text);
                    break;
                default:
                    return;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Enable the main panel if it was disabled
            formMain.UpdateMainPanelEnabled(true);
            AppSettings.InstallPath = txtTools.Text;
            AppSettings.DataPath = txtData.Text;
            AppSettings.SaveSettings();
        }

        private string GetBackupLocation()
        {
            if(File.Exists(AppSettings.SettingsFolder + AppSettings.BackupFile))
            {
                return File.ReadAllText(AppSettings.SettingsFolder + AppSettings.BackupFile);
            }
            return "Backup in progress...";
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            Process.Start(txtBackup.Text);
        }

        private void TxtBackup_TextChanged(object sender, EventArgs e)
        {
            if(txtBackup.Text == "Backup in progress...")
            {
                btnBackup.Visible = false;
            }
            else
            {
                btnBackup.Visible = true;
            }
        }
    }
}

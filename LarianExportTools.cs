using Microsoft.WindowsAPICodePack.Shell.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS3SimpleModder
{
    public class LarianExportTool
    {
        private static readonly string GustavPAK = @"\Gustav.PAK";
        private static readonly string SharedPAK = @"\Shared.PAK";

        public static void CreateBackupOfData()
        {
            if(AppSettings.InstallPath == "" || AppSettings.DataPath == "") { return; }
            if(!Directory.Exists(AppSettings.InstallPath) || !Directory.Exists(AppSettings.DataPath)) { return; }

            string dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BaldursGateData_" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss");
            Directory.CreateDirectory(dest);

            CopyFiles(dest);

            File.WriteAllText(AppSettings.SettingsFolder + AppSettings.BackupFile, dest);
        }

        public static void Unpack()
        {
            // Create a mod_TIMESTAMP directory inside the \Data\ folder
            if(!Directory.Exists(AppSettings.DataPath + @"\mod"))
            {
                Directory.CreateDirectory(AppSettings.DataPath + @"\mod");
            }

            // Start a cmd process in AppSettings.InstallPath
            string command = $"divine -g bg3 -s {AppSettings.DataPath + GustavPAK} -d {AppSettings.DataPath + @"\mod"} --use-package-name";
        }

        private static void CopyFiles(string dest)
        {
            File.Copy(AppSettings.DataPath + GustavPAK, dest + GustavPAK);
            File.Copy(AppSettings.DataPath + SharedPAK, dest + SharedPAK);
        }
    }
}

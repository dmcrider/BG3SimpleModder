using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BS3SimpleModder
{
    public class AppSettings
    {
        public static string InstallPath;
        public static string DataPath;
        public static readonly string SettingsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BG3SimpleModder\";
        public static readonly string BackupFile = "BackupLocation.txt";
        private static readonly string SettingsFile = "Settings.txt";

        public static void LoadSettings()
        {
            if (Directory.Exists(SettingsFolder))
            {
                if(File.Exists(SettingsFolder + SettingsFile))
                {
                    using(StreamReader reader = new StreamReader(SettingsFolder + SettingsFile))
                    {
                        string line;
                        while((line = reader.ReadLine()) != null)
                        {
                            var lineSplit = line.Split('=');

                            if(lineSplit[0] == "InstallPath")
                            {
                                InstallPath = lineSplit[1];
                            }
                            else if(lineSplit[0] == "DataPath")
                            {
                                DataPath = lineSplit[1];
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    new Thread(new ThreadStart(LarianExportTool.CreateBackupOfData)).Start();
                }
                else
                {
                    InstallPath = "";
                    DataPath = "";
                    return; // Nothing to load
                }
            }
            else
            {
                Directory.CreateDirectory(SettingsFolder);
                LoadSettings();
            }
        }

        public static void SaveSettings()
        {
            if (Directory.Exists(SettingsFolder))
            {
                if (File.Exists(SettingsFolder + SettingsFile))
                {
                    string output = $"InstallPath={InstallPath}\nDataPath={DataPath}";
                    File.WriteAllText(SettingsFolder + SettingsFile, output);
                }
            }
            else
            {
                Directory.CreateDirectory(SettingsFolder);
                LoadSettings();
            }
        }
    }
}

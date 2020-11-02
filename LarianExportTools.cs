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
        public static string InstallPath = "";
        public static string DataPath = "";
        private static readonly string _toolName = "ExportTool";

        public static void GetInstallPath()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string[] allDirs = Directory.GetDirectories(path);

            foreach (string dir in allDirs)
            {
                if (dir.Contains(_toolName))
                {
                    InstallPath = dir;
                    return;
                }
            }
        }

        public static void GetDataPath()
        {
            var path = Environment.SpecialFolder.ProgramFiles + @"\Steam\steamapps\common\Baldurs Gate 3\Data";

            if (Directory.Exists(path))
            {
                DataPath = path;
                return;
            }
        }
    }
}

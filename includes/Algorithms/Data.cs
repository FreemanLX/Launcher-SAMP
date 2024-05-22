using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace LauncherSAMPInt
{
    public static class Data
    {
        public static Dictionary<string, bool> reading = new Dictionary<string, bool>()
        {
            { "Location", false }, {"Dark", false }, {"Close", false }
        };

        public static string folderLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\LAMP";
        public static string serversLocation = folderLocation + "\\servers.set";
        public static string nicknameLocation = folderLocation + "\\dataname.set";

        public static Thread update;
        public static DefaultForm defaultform_generally;
        public static string GTALocation = "";

        public static void Save()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\GTA San Andreas User Files\\settings.set";
            File.Delete(path);
            File.Create(path).Close();
            string[] strArray2 = new string[]
            {
                  reading["Location"] ? "Location 1" : "Location 0",
                  reading["Dark"] ? "Dark 1" : "Dark 0",
                  reading["Close"] ? "Close 1" : "Close 0"
            };
            foreach (string str in strArray2) File.AppendAllText(path, str + Environment.NewLine);
        }
    }
}

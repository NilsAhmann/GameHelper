using System;
using System.IO;

namespace GameHelper.Global
{
    public static class Common
    {
        public static string GetDownloadFolder => ReWriteFoldersIfDefault(Properties.Settings.Default["DownloadFolder"]?.ToString());

        public static string ReWriteFoldersIfDefault(string folder)
        {
            folder = folder.Replace(@"%DOCUMENTS%", Environment.SpecialFolder.MyDocuments.ToString());
            folder = folder.Replace(@"%DOWNLOADS%", Path.Combine(Environment.SpecialFolder.UserProfile.ToString(), "Downloads"));

            return folder;
        }
    }
}

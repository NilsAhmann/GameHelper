using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GameHelper.Global
{
    public static class FileOperations
    {
        public static List<FileInfo> GetFileNamesByFilter(string searchfolder, string wildcardFilter)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(searchfolder);
            List<FileInfo> _result = new List<FileInfo>();

            if (!CheckDirectory(searchfolder))
                return (List<FileInfo>)Enumerable.Empty<FileInfo>();

            _result.AddRange(directoryInfo.GetFiles().Where(file => file.FullName.ToUpper().Contains(wildcardFilter.ToUpper())));

            return _result;
        }

        public static void MoveFile(FileInfo source, string target)
        {
            if (!File.Exists(source.FullName))
                return;

            if (File.Exists(Path.Combine(target, source.Name)))
                return;

            File.Move(source.FullName, Path.Combine(target, source.Name));
        }

        public static void DeleteFile(FileInfo file)
        {
            DeleteFile(file.FullName);
        }
        public static void DeleteFile(string file)
        {
            if (File.Exists(file))
                File.Delete(file);
        }

        private static bool CheckDirectory(string searchfolder)
        {
            return Directory.Exists(searchfolder);
        }
    }
}

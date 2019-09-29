using System;
using System.IO;
using FSCoreLibrary.Interfaces;

namespace FSCoreLibrary.Services
{
    class FileService : IFileService
    {
        public void Copy(string sourceFile, string targetFile)
        {
            var directory = Path.GetDirectoryName(targetFile);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (File.Exists(targetFile))
                targetFile = RenameFile(targetFile);

            File.Copy(sourceFile, targetFile, false);
        }

        private string RenameFile(string targetFile)
        {
            var directory = Path.GetDirectoryName(targetFile);
            var fileName = Path.GetFileNameWithoutExtension(targetFile);
            var fileExt = Path.GetExtension(targetFile);
            var date = DateTime.Now.Ticks.ToString();
            fileName = $"{fileName}({date}){fileExt}";
            var path =  Path.Combine(directory, fileName);
            return path;
        }
    }
}

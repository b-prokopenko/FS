using FSCoreLibrary.Interfaces;
using System;
using System.IO;

namespace FSCoreLibrary.Services
{
    class PathService : IPathService
    {
        public string BuildPath(string sourceFilePath, string targetFolder)
        {
            string name = Path.GetFileName(sourceFilePath);
            string extension = Path.GetExtension(sourceFilePath).Remove(0, 1);
            DateTime creationDate = File.GetCreationTime(sourceFilePath);
            string[] subFoldersArray = creationDate.ToString("yyyy.MM.dd").Split('.');
            string subFolders = Path.Combine(subFoldersArray);
            return Path.Combine(targetFolder, subFolders, extension, name);
        }
    }
}

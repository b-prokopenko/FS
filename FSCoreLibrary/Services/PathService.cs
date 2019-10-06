using FSCoreLibrary.Interfaces;
using System;
using System.IO;

namespace FSCoreLibrary.Services
{
    class PathService : IPathService
    {
        public string BuildPath(string targetFolder, string file)
        {
            string fileName = Path.GetFileName(file);
            //string fileExtension = Path.GetExtension(file).Remove(0, 1);
            DateTime creationDate = File.GetLastWriteTime(file);
            string[] subFoldersArray = creationDate.ToString("yyyy.MMMM.dd").Split('.');
            string subFolders = Path.Combine(subFoldersArray);
            //return Path.Combine(targetFolder, subFolders, fileExtension, fileName);
            return Path.Combine(targetFolder, subFolders, fileName);
        }
    }
}

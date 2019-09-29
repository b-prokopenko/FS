using FSCoreLibrary.Interfaces;
using System;
using System.IO;

namespace FSCoreLibrary.Services
{
    class PathService : IPathService
    {
        public string BuildPath(string source, string target)
        {
            string name = Path.GetFileName(source);
            string extension = Path.GetExtension(source).Remove(0, 1);
            DateTime date = File.GetCreationTime(source);
            string[] subFoldersArray = date.ToString("yyyy.MM.dd").Split('.');
            string subFolders = Path.Combine(subFoldersArray);
            return Path.Combine(target, subFolders, extension, name);
        }
    }
}

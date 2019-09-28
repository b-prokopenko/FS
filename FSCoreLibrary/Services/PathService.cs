using FSCoreLibrary.Interfaces;
using System.IO;

namespace FSCoreLibrary.Services
{
    class PathService : IPathService
    {
        public string BuildPath(IFileProperties fileProperties)
        {
            string newPath;
            string[] folders = fileProperties.CreationDate.ToString("yyyy.MM.dd").Split('.');
            string datePart = Path.Combine(folders);
            string extensionPart = fileProperties.Extension.Remove(0, 1);
            string name = fileProperties.Name;
            newPath = Path.Combine(datePart, extensionPart, $"{name}.{extensionPart}");
            return newPath;
        }
    }
}

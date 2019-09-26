using FS.Entities;
using FS.Interfaces;
using System.IO;

namespace FS.Services
{
    class PropertiesService : IPropertyService
    {
        public IFileProperties GetFileProperties(string filePath)
        {
            return new FileProperties()
            {
                Path = filePath,
                Name = Path.GetFileNameWithoutExtension(filePath),
                Extension = Path.GetExtension(filePath),
                Folder = Path.GetDirectoryName(filePath),
                CreationDate = File.GetCreationTime(filePath)
            };
        }
    }
}

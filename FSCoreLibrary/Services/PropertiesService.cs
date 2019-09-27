using FSCoreLibrary.Entities;
using FSCoreLibrary.Interfaces;
using System.IO;

namespace FSCoreLibrary.Services
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

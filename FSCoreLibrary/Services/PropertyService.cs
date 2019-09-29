using FSCoreLibrary.Entities;
using FSCoreLibrary.Interfaces;
using System.IO;

namespace FSCoreLibrary.Services
{
    class PropertyService : IPropertyService
    {
        public IFileProperties[] GetFilesProperties(string source)
        {
            string[] files = Directory.GetFiles(source, "*", SearchOption.AllDirectories);
            IFileProperties[] properties = new FileProperties[files.Length];
            for(int i = 0; i < properties.Length; i++)
            {
                properties[i] = GetProperties(files[i]);
            }
            return properties;
        }

        private IFileProperties GetProperties(string filePath)
        {
            return new FileProperties()
            {
                Path = filePath,
                Name = Path.GetFileName(filePath),
                Extension = Path.GetExtension(filePath),
                Folder = Path.GetDirectoryName(filePath),
                CreationDate = File.GetCreationTime(filePath)
            };
        }
    }
}

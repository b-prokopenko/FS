using FSCoreLibrary.Interfaces;
using System;

namespace FSCoreLibrary.Entities
{
    public class FileProperties : IFileProperties
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Folder { get; set; }
        public string Extension { get; set; }
        public DateTime CreationDate { get; set; }
    }
}

using System;
using FSCoreLibrary.Services;
using FSCoreLibrary.Interfaces;

namespace FSCoreLibrary
{
    public static class FSCore
    {
        public static IPropertyService PropertyService { get => GetInstanceOf<PropertyService>(); }
        public static IPathService PathService { get => GetInstanceOf<PathService>(); }
        public static IFileService FileService { get => GetInstanceOf<FileService>(); }

        private static T GetInstanceOf<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        public static void Sort(string source, string target)
        {
            
            PropertyService.GetFilesProperties(source);
            throw new NotImplementedException();
        }
    }
}

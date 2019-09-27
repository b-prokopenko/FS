using FSCoreLibrary.Interfaces;
using FSCoreLibrary.Services;

namespace FSCoreLibrary
{
    public static class FSCore
    {
        public static IPropertyService PropertyService { get => GetPropertyService(); }
        public static IFileService FileService { get => GetFileService(); }

        private static IFileService GetFileService()
        {
            return new FileService();
        }

        private static IPropertyService GetPropertyService()
        {
            return new PropertiesService();
        }

    }
}

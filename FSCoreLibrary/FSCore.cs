using System;
using FSCoreLibrary.Services;
using FSCoreLibrary.Interfaces;

namespace FSCoreLibrary
{
    public static class FSCore
    {
        public static IPropertyService PropertyService { get => GetService<PropertyService>(); }
        public static IPathService PathService { get => GetService<PathService>(); }

        private static T GetService<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}

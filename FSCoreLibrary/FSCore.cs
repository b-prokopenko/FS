using System;
using FSCoreLibrary.Services;
using FSCoreLibrary.Interfaces;

namespace FSCoreLibrary
{
    public static class FSCore
    {
        public static IPropertyService PropertyService { get => GetInstanceOf<PropertyService>(); }
        public static IPathService PathService { get => GetInstanceOf<PathService>(); }

        private static T GetInstanceOf<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}

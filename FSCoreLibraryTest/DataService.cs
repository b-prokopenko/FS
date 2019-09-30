using FSCoreLibraryTest.Data;
using FSCoreLibraryTest.Interfaces;
using System;
using System.IO;

namespace FSCoreLibraryTest
{
    static class DataService
    {
        public static ITestData TestData { get => GetData<TestData>(); }

        private static T GetData<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}

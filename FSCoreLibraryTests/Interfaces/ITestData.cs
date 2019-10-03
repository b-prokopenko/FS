using FSCoreLibrary.Interfaces;
using System;

namespace FSCoreLibraryTests.Interfaces
{
    public interface ITestData : IDisposable
    {
        ISortParams SortParams { get; }

        void PrepareFolder(string path);
        void PrepareFiles(int filescount, int subfoldersCount, string path);
    }
}

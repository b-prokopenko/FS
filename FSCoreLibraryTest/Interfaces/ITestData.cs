using FSCoreLibrary.Interfaces;

namespace FSCoreLibraryTest.Interfaces
{
    interface ITestData
    {
        IFileService FileServiceMock { get; }
        ISortService SortServiceMock { get; }
        IPathService PathServiceMock { get; }
        string SourcesFolder { get; }
        string[] FilesInSourceFolder { get; }
        string TestFile { get; }
        string WorkingFolder { get; }
        string TestFileName { get; }
    }
}

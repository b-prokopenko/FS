namespace FSCoreLibraryTest.Interfaces
{
    interface ITestData
    {
        string SourcesFolder { get; }
        string[] FilesInSourceFolder { get; }
        string TestFile { get; }
        string WorkingFolder { get; }
        string TestFileName { get; }
    }
}

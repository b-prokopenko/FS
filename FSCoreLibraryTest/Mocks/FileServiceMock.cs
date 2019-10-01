using FSCoreLibrary.Interfaces;

namespace FSCoreLibraryTest.Mocks
{
    class FileServiceMock : IFileService
    {
        public void Copy(string sourceFile, string targetFile)
        {
            throw new System.NotImplementedException();
        }
    }
}

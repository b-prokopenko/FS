using System.IO;
using FSCoreLibrary.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSCoreLibraryTest.Services
{
    [TestClass]
    public class PathServiceTest
    {
        IPathService service = DataService.TestData.PathServiceMock;
        IFileService properties = DataService.TestData.FileServiceMock;
        [TestMethod]
        public void ShouldBuildPathFromProperties()
        {
            string pathToFile = Path.Combine(Directory.GetCurrentDirectory(), "test", "testfile.txt");
            string targetFolder = Path.Combine(Directory.GetCurrentDirectory(), "target");
            string newPath = service.BuildPath(targetFolder, pathToFile);
            string expectedPath = $"{targetFolder}\\1601\\01\\01\\txt\\testfile.txt";
            Assert.AreEqual(expectedPath, newPath);
        }
    }
}

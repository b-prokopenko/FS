using System.IO;
using FS;
using FS.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSTests.Services
{
    [TestClass]
    public class FileServiceTest
    {
        IFileService service = FSCore.FileService;
        IPropertyService properties = FSCore.PropertyService;
        [TestMethod]
        public void ShouldBuildPathFromProperties()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "test", "testfile.txt");
            string newPath = service.BuildPath(properties.GetFileProperties(path));
            string expectedPath = "1601\\01\\01\\txt\\testfile.txt";
            Assert.AreEqual(expectedPath, newPath);
        }
    }
}

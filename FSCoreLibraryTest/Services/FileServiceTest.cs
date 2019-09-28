using System;
using System.IO;
using FSCoreLibrary;
using FSCoreLibrary.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSCoreLibraryTest.Services
{
    [TestClass]
    public class FileServiceTest
    {
        IPathService service = FSCore.PathService;
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

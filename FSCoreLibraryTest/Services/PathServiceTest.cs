using System;
using System.IO;
using FSCoreLibrary;
using FSCoreLibrary.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSCoreLibraryTest.Services
{
    [TestClass]
    public class PathServiceTest
    {
        IPathService service = FSCore.PathService;
        IPropertyService properties = FSCore.PropertyService;
        [TestMethod]
        public void ShouldBuildPathFromProperties()
        {
            string pathToFile = Path.Combine(Directory.GetCurrentDirectory(), "test", "testfile.txt");
            string targetFolder = Path.Combine(Directory.GetCurrentDirectory(), "target");
            string newPath = service.BuildPath(pathToFile, targetFolder);
            string expectedPath = $"{targetFolder}\\1601\\01\\01\\txt\\testfile.txt";
            Assert.AreEqual(expectedPath, newPath);
        }
    }
}

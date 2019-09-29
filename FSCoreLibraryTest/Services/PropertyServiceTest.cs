using System;
using System.IO;
using FSCoreLibrary;
using FSCoreLibrary.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSCoreLibraryTest.Services
{
    [TestClass]
    public class PropertyServiceTest
    {
        string SourceFolder = Path.Combine(Directory.GetCurrentDirectory(), "files");
        IPropertyService service = FSCore.PropertyService;
        [TestMethod]
        public void ShouldReturnFilesProperties()
        {
            string[] files = Directory.GetFiles(SourceFolder);
            var properties = service.GetFilesProperties(SourceFolder);
            for (int i = 0; i < properties.Length; i++)
            {
                Assert.IsNotNull(properties[i].Path);
                Assert.IsNotNull(properties[i].Name);
                Assert.IsNotNull(properties[i].Folder);
                Assert.IsNotNull(properties[i].Extension);
                Assert.IsNotNull(properties[i].CreationDate);
                Assert.AreEqual(properties[i].Path, files[i]);
            }
        
        }

        [TestMethod]
        public void CountOfPropertiesAndFilesShouldBeEqual()
        {
            string[] files = Directory.GetFiles(SourceFolder);
            var properties = service.GetFilesProperties(SourceFolder);
            Assert.AreEqual(files.Length, properties.Length);
        }

        [TestMethod]
        public void PropertiesShouldNotContainNull()
        {
            var properties = service.GetFilesProperties(SourceFolder);
            foreach (var property in properties)
                Assert.IsNotNull(property);
        }
    }
}
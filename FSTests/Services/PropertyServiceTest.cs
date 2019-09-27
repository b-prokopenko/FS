﻿using System.IO;
using FS;
using FS.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSTests.Services
{
    [TestClass]
    public class PropertyServiceTest
    {
        IPropertyService service = FSCore.PropertyService; 
        [TestMethod]
        public void ShouldReturnFileProperties()
        {
            string testFile = Path.Combine(Directory.GetCurrentDirectory(), "test", "testfile.txt");
            var properties = service.GetFileProperties(testFile);
            Assert.IsNotNull(properties.Path);
            Assert.IsNotNull(properties.Name);
            Assert.IsNotNull(properties.Folder);
            Assert.IsNotNull(properties.Extension);
            Assert.IsNotNull(properties.CreationDate);
            Assert.AreEqual(properties.Path, testFile);
        }
    }
}
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
        IFileService service = FSCore.FileService;

        [TestMethod]
        public void ShouldCopyFileToTargetFolder()
        {
            string sourceFile = DataService.TestData.TestFile;
            string targetFile = Path.Combine(DataService.TestData.WorkingFolder, "targets", DataService.TestData.TestFileName);
            service.Copy(sourceFile, targetFile);
            bool expectedFolder = Directory.Exists(Path.GetDirectoryName(targetFile));
            Assert.IsTrue(expectedFolder);
            Assert.IsTrue(File.Exists(targetFile));
        }

        [TestMethod]
        public void ShouldRenameFileIfExists()
        {
            string[] testFiles = DataService.TestData.FilesInSourceFolder;
            string targetFolder = Path.Combine(DataService.TestData.WorkingFolder, "targets");
            foreach (string file in testFiles)
            {
                var targetFileName = Path.GetFileName(file);
                var targetFile = Path.Combine(targetFolder, targetFileName);
                service.Copy(file, targetFile);
                Assert.IsTrue(File.Exists(targetFile));
            }
        }
    }
}
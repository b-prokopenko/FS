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
            string fileName = "testfile.txt";
            string targetFile = Path.Combine(DataService.TestFolder, "targets", fileName);
            string sourceFile = DataService.PrepareTestFile(fileName);
            service.Copy(sourceFile, targetFile);
            bool expectedFolder = Directory.Exists(Path.GetDirectoryName(targetFile));
            Assert.IsTrue(expectedFolder);
            Assert.IsTrue(File.Exists(targetFile));
        }

        [TestMethod]
        public void ShouldRenameFileIfExists()
        {
            string[] testFiles = DataService.PrepareTestFiles();
            string targetFolder = Path.Combine(DataService.TestFolder, "targets");
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
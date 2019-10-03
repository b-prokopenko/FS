using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace FSCoreLibraryTest
{
    [TestClass]
    public class FSCoreTest
    {

        [TestMethod]
        public void ShouldSortFilesByCreationDate()
        {
            var data = DataService.TestData;
            var sourceFolder = data.SourcesFolder;
            var files = data.FilesInSourceFolder;
            var targetFolder = Path.Combine(data.WorkingFolder, "targets");
            var sortedFiles = Directory.GetFiles(targetFolder, "*", SearchOption.AllDirectories);
            foreach (var file in sortedFiles)
            {
                var fileName = Path.GetFileName(file);
                var fileExtension = Path.GetExtension(file).Remove(0, 1);
                var subfolders = File.GetCreationTime(file).ToString("yyyy.MM.dd").Split('.');
                var subfoldersPath = Path.Combine(subfolders);
                var expectedFile = Path.Combine(targetFolder, subfoldersPath, fileExtension, fileName);
                Assert.IsTrue(File.Exists(expectedFile));
            }
        }

        [TestMethod]
        public void ShouldTrackProgress()
        {
            var data = DataService.TestData;
            var sourceFolder = data.SourcesFolder;
            var files = data.FilesInSourceFolder;
            var targetFolder = Path.Combine(data.WorkingFolder, "targets");

            FSCoreLibrary.FSCore.Service.Sort(sourceFolder, targetFolder);

            var actualTotal = FSCoreLibrary.FSCore.Progress.Total;
            var actualReady = FSCoreLibrary.FSCore.Progress.Ready;
            Assert.AreEqual(files.Length, actualTotal);
            Assert.AreEqual(files.Length, actualReady);
            Assert.AreEqual(actualTotal, actualReady);
        }
    }
}

using FSCoreLibrary;
using FSCoreLibrary.Interfaces;
using FSCoreLibraryTests.Data;
using System.IO;
using Xunit;

namespace FSCoreLibraryTests.Integration
{
    public class FSCoreTest
    {
        ISortParams Params = DataService.Data.SortParams;

        [Fact]
        void ShouldSortFiles()
        {
            DataService.Data.PrepareFolder(Params.SourceFolder);
            DataService.Data.PrepareFiles(20, 5, Params.SourceFolder);
            FSCore.Service.Sort(Params);
            var actualTotal = FSCore.Service.Total;
            var actualReady = FSCore.Service.Ready;
            var files = Directory.GetFiles(Params.TargetFolder, "*", SearchOption.AllDirectories);
            Assert.Equal(files.Length, actualTotal);
            Assert.Equal(files.Length, actualReady);
            Assert.Equal(actualTotal, actualReady);
            DataService.Data.Dispose();
        }
    }
}

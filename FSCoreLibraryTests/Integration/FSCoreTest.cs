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
        ISortService Service = FSCore.Service;

        [Fact]
        void ShouldSortFiles()
        {
            DataService.Data.PrepareFolder(Params.SourceFolder);
            DataService.Data.PrepareFiles(20, 5, Params.SourceFolder);
            Service.Sort(Params);
            var actualTotal = Service.Total;
            var actualReady = Service.Ready;
            var files = Directory.GetFiles(Params.TargetFolder, "*", SearchOption.AllDirectories);
            Assert.Equal(files.Length, actualTotal);
            Assert.Equal(files.Length, actualReady);
            Assert.Equal(actualTotal, actualReady);
            DataService.Data.Dispose();
        }
    }
}

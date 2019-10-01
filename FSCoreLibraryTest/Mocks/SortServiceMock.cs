using FSCoreLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSCoreLibraryTest.Mocks
{
    class SortServiceMock : ISortService
    {
        public void Sort(string sourceFolder, string targetFolder)
        {
            throw new NotImplementedException();
        }
    }
}

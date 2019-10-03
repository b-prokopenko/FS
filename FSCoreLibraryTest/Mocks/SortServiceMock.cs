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
       

        public void Sort(ISortParams sortParams)
        {
            throw new NotImplementedException();
        }

        public int Total => throw new NotImplementedException();

        public int Ready => throw new NotImplementedException();
    }
}

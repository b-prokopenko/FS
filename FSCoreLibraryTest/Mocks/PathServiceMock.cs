using FSCoreLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSCoreLibraryTest.Mocks
{
    class PathServiceMock : IPathService
    {
        public string BuildPath(string targetFolder, string file)
        {
            throw new NotImplementedException();
        }
    }
}

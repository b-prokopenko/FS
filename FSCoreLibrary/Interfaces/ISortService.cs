using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSCoreLibrary.Interfaces
{
    public interface ISortService
    {
        void Sort(ISortParams sortParams);
        IList<Task> Tasks { get; }
        void PrepareTasks(ISortParams sortParams);
    }
}

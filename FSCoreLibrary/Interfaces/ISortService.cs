using System;

namespace FSCoreLibrary.Interfaces
{
    public interface ISortService
    {
        int Total { get; }
        int Ready { get; }
        string InProgress { get; }
        void Sort(ISortParams sortParams);
    }
}

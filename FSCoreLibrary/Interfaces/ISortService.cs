namespace FSCoreLibrary.Interfaces
{
    public interface ISortService
    {
        int Total { get; }
        int Ready { get; }
        void Sort(ISortParams sortParams);
    }
}

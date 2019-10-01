namespace FSCoreLibrary.Interfaces
{
    public interface IProgress
    {
        int Total { get; }
        int Ready { get; }
        string InProgress { get; }
    }
}

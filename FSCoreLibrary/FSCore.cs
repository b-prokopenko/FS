using FSCoreLibrary.Services;
using FSCoreLibrary.Interfaces;

namespace FSCoreLibrary
{
    public static class FSCore
    {
        public static ISortService Service { get => new SortService(); }
    }
}

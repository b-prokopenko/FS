using FSCoreLibrary.Interfaces;

namespace FSWFGui.Entities
{
    class SortParams : ISortParams
    {
        public string SourceFolder { get; set; } = "";
        public string TargetFolder { get; set; } = "";
        public bool IsReady()
        {
            return FoldersAreNotEmpty() && FoldersAreNotNull();
        }

        private bool FoldersAreNotEmpty()
        {
            return (SourceFolder.Length > 0) && (TargetFolder.Length > 0);
        }

        private bool FoldersAreNotNull()
        {
            return (SourceFolder.Length > 0) && (TargetFolder.Length > 0);
        }
    }
}

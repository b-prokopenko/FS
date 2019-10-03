using System.IO;
using FSCoreLibrary.Interfaces;
using FSCoreLibraryTests.Data;

namespace FSCoreLibraryTests.Mocks
{
    class SortParamsMock : ISortParams
    {
        private string _sourceFolder = "";
        private string _targetFolder = "";
        public string SourceFolder { get=> GetSourceFolder(); set => SetSourceFolder(value); }
        public string TargetFolder { get => GetTargetFolder(); set => SetTargetFolder(value); }

        private void SetSourceFolder(string value)
        {
            _sourceFolder = value;
        }

        private string GetSourceFolder()
        {
            if(IsEmpty(_sourceFolder))
                _sourceFolder = GetFolder(Constants.SOURCES_FOLDER);
            return _sourceFolder;
        }
        
        private string GetTargetFolder()
        {
            if (IsEmpty(_targetFolder))
                _targetFolder = GetFolder(Constants.TARGETS_FOLDER);
            
            return _targetFolder;
        }

        private void SetTargetFolder(string targetFolder)
        {
            _targetFolder = targetFolder;
        }

        private string GetFolder(string folderName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string testFolder = Constants.TEST_FOLDER;
            return Path.Combine(currentDirectory, testFolder, folderName);
        }

        private bool IsEmpty(string sourceFolder)
        {
            return sourceFolder.Length < 1;
        }
    }
}

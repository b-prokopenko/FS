using System;
using System.IO;
using FSCoreLibrary.Interfaces;

namespace FSCoreLibrary.Services
{
    class SortService : ISortService, IProgress
    {
        public int Total { get; private set; }
        public int Ready { get; private set; }
        public string InProgress { get; private set; }
        private IFileService _fileService { get => GetInstanceOf<FileService>(); }
        private IPathService _pathService { get => GetInstanceOf<PathService>(); }

        public void Sort(string sourceFolder, string targetFolder)
        {
            string[] sourceFiles = Directory.GetFiles(sourceFolder, "*", SearchOption.AllDirectories);
            string[] targetFiles = new string[sourceFiles.Length];

            Total = sourceFiles.Length;
            Ready = 0;

            for (int i = 0; i < sourceFiles.Length; i++)
            {
                InProgress = Path.GetFileName(sourceFiles[i]);
                targetFiles[i] = _pathService.BuildPath(targetFolder, sourceFiles[i]);
                _fileService.Copy(sourceFiles[i], targetFiles[i]);
                Ready++;
            }
        }

        private T GetInstanceOf<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}

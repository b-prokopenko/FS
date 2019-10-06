using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using FSCoreLibrary.Interfaces;

namespace FSCoreLibrary.Services
{
    class SortService : ISortService
    {
        public IList<Task> Tasks { get; private set; }
        private IFileService _fileService { get => GetInstanceOf<FileService>(); }
        private IPathService _pathService { get => GetInstanceOf<PathService>(); }

        public void Sort(ISortParams sortParams)
        {
            //string[] sourceFiles = Directory.GetFiles(sortParams.SourceFolder, "*", SearchOption.AllDirectories);
            //string[] targetFiles = new string[sourceFiles.Length];

            //Total = sourceFiles.Length;
            //Ready = 0;

            //for (int i = 0; i < sourceFiles.Length; i++)
            //{
            //    InProgress = Path.GetFileName(sourceFiles[i]);
            //    targetFiles[i] = _pathService.BuildPath(sortParams.TargetFolder, sourceFiles[i]);
            //    _fileService.Copy(sourceFiles[i], targetFiles[i]);
            //    Ready = i;
            //}
            throw new NotImplementedException();
        }

        private T GetInstanceOf<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
         public void PrepareTasks(ISortParams sortParams)
        {
            string[] sourceFiles = Directory.GetFiles(sortParams.SourceFolder, "*", SearchOption.AllDirectories);
            Tasks = new List<Task>();

            foreach(string sourceFile in sourceFiles)
            {
                string targetFile = _pathService.BuildPath(sortParams.TargetFolder, sourceFile);
                Task task = new Task(() => {
                    _fileService.Copy(sourceFile, targetFile);
                });
                Tasks.Add(task);
            }
        }
    }
}

using FSCoreLibrary.Interfaces;
using FSCoreLibraryTest.Interfaces;
using FSCoreLibraryTest.Mocks;
using System;
using System.IO;

namespace FSCoreLibraryTest.Data
{
    struct TestData : ITestData
    {
        public IFileService FileServiceMock => GetInstanceOf<FileServiceMock>();

        public ISortService SortServiceMock => GetInstanceOf<SortServiceMock>();

        public IPathService PathServiceMock => GetInstanceOf<PathServiceMock>();
        private string _workingPath { get => Path.Combine(Directory.GetCurrentDirectory(), "TestFolder"); }
        public string WorkingFolder { get => GetWorkingFolder(); }
        public string SourcesFolder { get => CreateSourcesFolder(); }
        public string[] FilesInSourceFolder { get => PrepareTestFiles(); }
        public string TestFile { get => PrepareTestFile(); }
        public string TestFileName { get => Path.GetFileName(TestFile); }

        private string GetWorkingFolder()
        {
            if (!Directory.Exists(_workingPath))
                Directory.CreateDirectory(_workingPath);
            return _workingPath;
        }

        private void CleanWorkingFolder()
        {
            var folders = Directory.GetDirectories(_workingPath);
            foreach (var folder in folders)
                Directory.Delete(folder, true);
        }

        private string CreateSourcesFolder()
        {
            string sourcesFolder = Path.Combine(WorkingFolder, "sources");
            if (!Directory.Exists(sourcesFolder))
                Directory.CreateDirectory(sourcesFolder);
            return sourcesFolder;
        }

        public string PrepareTestFile()
        {
            CleanWorkingFolder();
            string fileName = "testfile.txt";
            string testContent = "Test Content";
            string file = Path.Combine(SourcesFolder, fileName);
            var stream = File.CreateText(file);
            stream.Write(testContent);
            stream.Close();
            return file;
        }

        public string[] PrepareTestFiles()
        {
            CleanWorkingFolder();
            int count = 20;
            string childFolder = Path.Combine(SourcesFolder, "child");
            string otherChildFolder = Path.Combine(SourcesFolder, "otherchild");
            if (!Directory.Exists(childFolder))
                Directory.CreateDirectory(childFolder);
            if (!Directory.Exists(otherChildFolder))
                Directory.CreateDirectory(otherChildFolder);


            for (int i = 0; i < count; i++)
            {
                FileStream stream;
                string fileName = $"testfile{i.ToString()}.txt";

                string pathOtherChild = Path.Combine(SourcesFolder, otherChildFolder, fileName);
                stream = File.Create(pathOtherChild);
                stream.Dispose();

                string pathChild = Path.Combine(SourcesFolder, childFolder, fileName);
                stream = File.Create(pathChild);
                stream.Dispose();

                string pathParent = Path.Combine(SourcesFolder, fileName);
                stream = File.Create(pathParent);
                stream.Dispose();
            }
            return Directory.GetFiles(SourcesFolder, "*", SearchOption.AllDirectories);
        }

        private T GetInstanceOf<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        
    }
}

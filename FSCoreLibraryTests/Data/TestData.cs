using System;
using System.IO;
using FSCoreLibrary.Interfaces;
using FSCoreLibraryTests.Interfaces;
using FSCoreLibraryTests.Mocks;

namespace FSCoreLibraryTests.Data
{
    class TestData : ITestData
    {
        public ISortParams SortParams => GetInstanceOf<SortParamsMock>();

        private T GetInstanceOf<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        public void PrepareFolder(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        public void PrepareFiles(int filescount, int subfoldersCount, string path)
        {
            for (int i = 0; i <= subfoldersCount; i++)
            {
                string subfolderPath = Path.Combine(path, i.ToString());
                if (!Directory.Exists(subfolderPath))
                    Directory.CreateDirectory(subfolderPath);

                for (int y = 0; y <= filescount; y++)
                {
                    string fileName = $"TestFile-{i}-{y}.{i}{y}";
                    string filePath = Path.Combine(subfolderPath, fileName);
                    if (!File.Exists(filePath))
                    {
                        FileStream stream = File.Create(filePath);
                        stream.Dispose();
                        DateTime creationDate = DateTime.Now.AddMonths(-i).AddDays(-y);
                        File.SetCreationTime(filePath, creationDate);
                    }
                }
            }
        }

        public void Dispose()
        {
            Directory.Delete(Path.Combine(Directory.GetCurrentDirectory(), Constants.TEST_FOLDER), true);
        }
    }
}

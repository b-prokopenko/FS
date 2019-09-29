using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSCoreLibraryTest
{
    static class DataService
    {
        public static string TestFolder = Path.Combine(Directory.GetCurrentDirectory(), "TestFolder");

        private static void CleanTestFolder()
        {
            if (Directory.Exists(TestFolder))
                Directory.Delete(TestFolder, true);
        }

        private static string CreateSourcesFolder()
        {
            string sourcesFolder = Path.Combine(TestFolder, "sources");
            if (!Directory.Exists(sourcesFolder))
                Directory.CreateDirectory(sourcesFolder);
            return sourcesFolder;
        }

        public static string PrepareTestFile(string fileName)
        {
            CleanTestFolder();

            string sourcesFolder = CreateSourcesFolder();
            string testContent = "Test Content";
            string file = Path.Combine(sourcesFolder, fileName);
            var stream = File.CreateText(file);
            stream.Write(testContent);
            stream.Close();
            return file;
        }

        public static string[] PrepareTestFiles()
        {
            CleanTestFolder();
            int count = 20;
            string sourcesFolder = CreateSourcesFolder();
            string childFolder = Path.Combine(sourcesFolder, "child");
            string otherChildFolder = Path.Combine(sourcesFolder, "otherchild");
            if (!Directory.Exists(childFolder))
                Directory.CreateDirectory(childFolder);
            if (!Directory.Exists(otherChildFolder))
                Directory.CreateDirectory(otherChildFolder);


            for (int i = 0; i < count; i++)
            {
                FileStream stream;
                string fileName = $"testfile{i.ToString()}.txt";

                string pathOtherChild = Path.Combine(sourcesFolder, otherChildFolder, fileName);
                stream = File.Create(pathOtherChild);
                stream.Dispose();

                string pathChild = Path.Combine(sourcesFolder, childFolder, fileName);
                stream = File.Create(pathChild);
                stream.Dispose();

                string pathParent = Path.Combine(sourcesFolder, fileName);
                stream = File.Create(pathParent);
                stream.Dispose();
            }
            return Directory.GetFiles(sourcesFolder, "*", SearchOption.AllDirectories);
        }
    }
}

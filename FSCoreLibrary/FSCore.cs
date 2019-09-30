using System;
using FSCoreLibrary.Services;
using FSCoreLibrary.Interfaces;
using System.IO;

namespace FSCoreLibrary
{
    public static class FSCore
    {
        public static IFileService FileService { get => GetInstanceOf<FileService>(); }
        public static IPathService PathService { get => GetInstanceOf<PathService>(); }
        public static int Total { get; set; } = 0;
        public static int Ready { get; set; } = 0;

        private static T GetInstanceOf<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        public static void Sort(string sourceFolder, string targetFolder)
        {
            string[] sourceFiles = Directory.GetFiles(sourceFolder, "*", SearchOption.AllDirectories);
            string[] targetFiles = new string[sourceFiles.Length];

            Total = sourceFiles.Length;
            Ready = 0;

            for (int i = 0; i < sourceFiles.Length; i++)
            {
                targetFiles[i] = PathService.BuildPath(targetFolder, sourceFiles[i]);
                FileService.Copy(sourceFiles[i], targetFiles[i]);
                Ready++;
            }
        }
    }
}

﻿using System;

namespace FS.Interfaces
{
    public interface IFileProperties
    {
        string Name { get; set; }
        string Path { get; set; }
        string Folder { get; set; }
        string Extension { get; set; }
        DateTime CreationDate { get; set; }
    }
}

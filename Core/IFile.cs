﻿namespace Core
{
    public interface IFile
    {
        void WriteAllText(string path, string contents);
    }
}
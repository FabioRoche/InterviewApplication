// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="IDirectoryWrapper.cs" company="Roche Diagnostics International Ltd">
//    Copyright (c) 2020 Roche Diagnostics International Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SystemWrappers
{
    public interface IFileSystemWrapper
    {
        string[] GetFiles(string directory);

        string GetFileContent(string fileName);
    }
}
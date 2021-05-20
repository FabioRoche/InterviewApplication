using System;

namespace SystemWrappers
{
    public class FileSystemWrapper : IFileSystemWrapper
    {
        public string[] GetFiles(string directory)
        {
            return new string[] { @"c:\MyDir\localFile.txt", @"c:\MyDir\localFile1.txt", @"c:\MyDir\localFile2.txt" };
        }

        public string GetFileContent(string fileName)
        {
            var content = "This is the content of file: " + fileName;
            return content;
        }
    }
}

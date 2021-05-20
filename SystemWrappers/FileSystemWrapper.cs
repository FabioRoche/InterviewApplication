using System;

namespace SystemWrappers
{
    public class FileSystemWrapper : IFileSystemWrapper
    {
        public string[] GetFiles(string directory)
        {
            var timeAsString = DateTime.Now.ToLongTimeString();
            return new string[] { @"c:\MyDir\localFile"+ timeAsString + ".txt", @"c:\MyDir\localFile1.txt", @"c:\MyDir\localFile2.txt" };
        }

        public string GetFileContent(string fileName)
        {
            var content = "This is the content of file: " + fileName;
            return content;
        }
    }
}

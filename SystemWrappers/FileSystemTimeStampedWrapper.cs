using System;
using System.Threading;

namespace SystemWrappers
{
    public class FileSystemTimeStampedWrapper : IFileSystemWrapper
    {
        public string[] GetFiles(string directory)
        {
            DoVeryHeavyStuff();
            var timeAsString = DateTime.Now.ToLongTimeString();
            return new string[] { @"c:\MyDir\localFile" + timeAsString + ".txt" };
        }

        public string GetFileContent(string fileName)
        {
            // TODO: The same as the FileSystemWrapper
            throw new NotImplementedException();
        }

        private void DoVeryHeavyStuff()
        {
            Thread.Sleep(2000);
        }
    }
}

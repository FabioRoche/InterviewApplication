using System;
using System.Threading;

namespace SystemWrappers
{
    public class FileSystemTimeStampedWrapper
    {
        public string[] GetFiles(string directory)
        {
            DoVeryHeavyStuff();
            var timeAsString = DateTime.Now.ToLongTimeString();
            return new string[] { @"c:\MyDir\localFile" + timeAsString + ".txt" };
        }

        public string GetFileContent(string thefilenameTxt)
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

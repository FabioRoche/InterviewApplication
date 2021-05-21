using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileService.Test
{
    [TestClass]
    public class FileSystemTimeStampedWrapper
    {
        [TestMethod]
        public void GetFiles_SomeDirectoryAtTimeNow_SameTimeStampedFilename()
        {
            // Arrange
            var timeAsString = DateTime.Now.ToLongTimeString();
            var fileSystemTimeStampedWrapper = new SystemWrappers.FileSystemTimeStampedWrapper();

            // Act
            var files = fileSystemTimeStampedWrapper.GetFiles("SomeDirectory");

            // Assert
            Assert.AreEqual(1, files.Length);
            Assert.AreEqual(@"c:\MyDir\localFile" + timeAsString + ".txt", files.Single());
        }
    }
}

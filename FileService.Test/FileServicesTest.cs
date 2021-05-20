using System.Linq;

namespace FilesService.Test
{
    using SystemWrappers;
    using Moq;
    using Moq.AutoMock;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FileServicesTest
    {
        [TestMethod]
        public void GetFiles_FileSystemAndWebServerContainFiles_ListOfAllFilesIsReturned()
        {
            // Arrange
            var mocker = new AutoMocker();
            
            var fileSystemWrapper = mocker.GetMock<IFileSystemWrapper>();
            fileSystemWrapper.Setup(dw => dw.GetFiles(It.IsAny<string>())).Returns(new string[] {"file1", "file2"});

            var webClientWrappper = mocker.GetMock<IWebClientWrapper>();
            webClientWrappper.Setup(dw => dw.GetFiles(It.IsAny<string>())).Returns( new string[] { "Webfile1" });

            var sut = mocker.CreateInstance<FilesService>();

            // Act
            var fileInformations = sut.GetFiles();

            // 
            Assert.AreEqual(3, fileInformations.Count());
        }
    }
}

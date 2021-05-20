namespace FilesService
{
    using System;
    using System.Collections.Generic;
    using SystemWrappers;

    public class FilesService : IFilesService
    {
        private readonly IFileSystemWrapper fileSystemWrapper;
        private readonly IWebClientWrapper webClientWrapper;

        public FilesService(IFileSystemWrapper fileSystemWrapper, IWebClientWrapper webClientWrapper)
        {
            this.fileSystemWrapper = fileSystemWrapper;
            this.webClientWrapper = webClientWrapper;
        }

        public IEnumerable<FileInformation> GetFiles()
        {
            var fileSystem = this.GetFilesSystem();
            var webFoldersFiles = this.GetWebFolderFiles();

            var result = new List<FileInformation>(fileSystem);
            result.AddRange(webFoldersFiles);

            return result;
        }

        public FileDetailedInformation GetFileDetailedInformation(FileInformation fileInformation)
        {
            // TODO: get file content
            string content = String.Empty;

            content = "Fetch content for file " + fileInformation.FileName + "needs to be implemented";

            var result = new FileDetailedInformation()
            {
                Content = content
            };

            return result;
        }

        private IEnumerable<FileInformation> GetFilesSystem()
        {
            var files = this.fileSystemWrapper.GetFiles("someDummyFolder");

            var result = new System.Collections.Generic.List<FileInformation>();
            foreach (var file in files)
            {
                result.Add(new FileInformation() { FileName = file, FileType = FileType.FileSystem });
            }

            return result;
        }

        private IEnumerable<FileInformation> GetWebFolderFiles()
        {
            var files = this.webClientWrapper.GetFiles("myServerFolder");

            var result = new System.Collections.Generic.List<FileInformation>();
            foreach (var file in files)
            {
                result.Add(new FileInformation() { FileName = file, FileType = FileType.ServerFolder });
            }

            return result;
        }
    }
}

namespace FilesService
{
    using System.Collections.Generic;

    public interface IFilesService
    {
        IEnumerable<FileInformation> GetFiles();
        FileDetailedInformation GetFileDetailedInformation(FileInformation fileInformation);
    }
}
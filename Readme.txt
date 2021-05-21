[![.NET](https://github.com/FabioRoche/InterviewApplication/actions/workflows/dotnet.yml/badge.svg)](https://github.com/FabioRoche/InterviewApplication/actions/workflows/dotnet.yml)

Explain Application: 
Aggregates all files from several sources (File system and web folder)

Give overview of the solution:
- FilesServices: get files from local system and web folders
...

Tasks:

X - Implement the method GetFileDetailedInformation (refactor if needed, or add comment it if takes time)
(Should mention some pattern, like strategy pattern, basically avoid the switch)
(Did he try to use the tests first?)

X - Implement FileSystemTimeStampedWrapper.GetFileContent
(Should mention ways of using inheritance, or composition, to not copy paste the code)
(Did he try to use the tests first?)

X - fix test GetFiles_SomeDirectoryAtTimeNow_SameTimeStampedFilename
(How will he solve the time problem? Some time service to mock or so...)

X - (ConsoleApp) - instantiate FilesService using Unity Container
(Does he know how a dependency injection container works?)
            UnityContainer.RegisterType<IFilesService, FilesService>();
            UnityContainer.RegisterType<IFileSystemWrapper, FileSystemWrapper>();
            UnityContainer.RegisterType<IWebClientWrapper, WebClientWrapper>();


X - (ConsoleApp) -  Log each filename followed by its content
(Only console write line)

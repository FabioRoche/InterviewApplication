using System;
using SystemWrappers;
using FilesService;
using Unity;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFilesService filesService = Bootstrapper.UnityContainer.Resolve<IFilesService>();

            Console.WriteLine("Hello World!");
        }
    }
}

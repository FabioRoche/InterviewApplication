namespace ConsoleApp
{
    using SystemWrappers;
    using FilesService;
    using Unity;

    public static class Bootstrapper
    {
        public static UnityContainer UnityContainer { get; }

        static Bootstrapper()
        {
            UnityContainer = new UnityContainer();
        }
    }
}

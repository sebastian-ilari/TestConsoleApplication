using System;
using Microsoft.Practices.Unity;
using TestConsoleApplication.Unity;

namespace TestConsoleApplication
{
    public class UnityStarterMain
    {
        private static IUnityContainer unityContainer;

        public static void Start(string[] args)
        {
            InitializeUnity();

            IRepository<Entity> repo = unityContainer.Resolve<IRepository<Entity>>();

            Builder<Entity> builder = unityContainer.Resolve<Builder<Entity>>();

            Console.WriteLine(builder.BuildName());

            Console.ReadKey();
        }

        public static void InitializeUnity()
        {
            unityContainer = new UnityContainer();
            unityContainer.RegisterType<IRepository<Entity>, Repository<Entity>>();
            unityContainer.RegisterType<Builder<Entity>, EntityBuilder>();
        }
    }
}
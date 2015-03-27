using System;

namespace TestConsoleApplication.DesignPatterns.Singleton
{
    public class SingletonPattern
    {
        public SingletonPattern()
        {
            Console.WriteLine("Singleton Pattern");
            Console.WriteLine(Environment.NewLine);

            Singleton.Instance.Show();
            Singleton.Instance.Show();

            Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
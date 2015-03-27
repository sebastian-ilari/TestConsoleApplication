using System;

namespace TestConsoleApplication.DesignPatterns.Strategy
{
    public class SilverWash : ICarwash
    {
        public void Wash()
        {
            Console.WriteLine("Silver wash");
        }
    }
}
using System;

namespace TestConsoleApplication.DesignPatterns.Strategy
{
    public class BronzeWash : ICarwash
    {
        public void Wash()
        {
            Console.WriteLine("Bronze wash");
        }
    }
}
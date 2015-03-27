using System;

namespace TestConsoleApplication.DesignPatterns.Facade
{
    public class FacadePattern
    {
        public FacadePattern()
        {
            Console.WriteLine("Facade Pattern");
            Console.WriteLine(Environment.NewLine);

            CarFacade facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();
        }
    }
}
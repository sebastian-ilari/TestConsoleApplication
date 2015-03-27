using System;
namespace TestConsoleApplication.DesignPatterns.Strategy
{
    public class StrategyPattern
    {
        public StrategyPattern()
        {
            Console.WriteLine("Strategy Design Pattern");
            Console.WriteLine(Environment.NewLine);

            CarService newCustomerService = new CarService(new BronzeWash()) { CustomerName = "Bob" };
            CarService regularCustomerService = new CarService(new SilverWash()) { CustomerName = "Ted" };
            newCustomerService.PerformMaintenance();
            regularCustomerService.PerformMaintenance();
            
            Console.ReadKey();
        }
    }
}
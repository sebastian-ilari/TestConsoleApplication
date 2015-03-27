using System;

namespace TestConsoleApplication.DesignPatterns.Strategy
{
    public class CarService
    {
        private readonly ICarwash carwash;

        public CarService(ICarwash carwash)
        {
            this.carwash = carwash;
        }

        public string CustomerName { get; set; }

        public void PerformMaintenance()
        {
            Console.WriteLine("Servicing {0}", CustomerName);
            Console.WriteLine("Oil Change");
            Console.WriteLine("Tire Pressure check");
            carwash.Wash();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
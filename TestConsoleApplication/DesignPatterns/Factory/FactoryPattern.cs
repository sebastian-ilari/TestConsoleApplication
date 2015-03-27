using System;

namespace TestConsoleApplication.DesignPatterns.Factory
{
    public class FactoryPattern
    {
        public FactoryPattern()
        {
            Console.WriteLine("Factory Pattern");
            Console.WriteLine(Environment.NewLine);

            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle(VehicleType.Scooter);
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle(VehicleType.Bike);
            bike.Drive(20);

            //This should throw an application exception
            //IFactory car = factory.GetVehicle(VehicleType.Car);
            //bike.Drive(20);

            Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
using System;

namespace TestConsoleApplication.DesignPatterns.Builder
{
    public class BuilderPattern
    {
        public BuilderPattern()
        {
            Console.WriteLine("Builder Pattern");
            Console.WriteLine(Environment.NewLine);

            VehicleCreator vehicleCreator = new VehicleCreator(new HeroBuilder());
            vehicleCreator.CreateVehicle();
            Vehicle vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("\n---------------------------------------------\n");

            vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.CreateVehicle();
            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
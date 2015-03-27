namespace TestConsoleApplication.DesignPatterns.Factory
{
    public enum VehicleType
    {
        Bike = 1,
        Scooter = 2,
        Car = 3
    };

    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(VehicleType vehicleType);
    }
}
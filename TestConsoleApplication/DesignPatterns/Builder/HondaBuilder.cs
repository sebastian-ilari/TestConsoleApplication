namespace TestConsoleApplication.DesignPatterns.Builder
{
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    public class HondaBuilder : IVehicleBuilder
    {
        Vehicle vehicle = new Vehicle();
        
        public void SetModel()
        {
            vehicle.Model = "Honda";
        }

        public void SetEngine()
        {
            vehicle.Engine = "6 Cylinders";
        }

        public void SetMaxSpeed()
        {
            vehicle.MaxSpeed = "150 Km/hr";
        }

        public void SetBody()
        {
            vehicle.Body = "Plastic";
        }

        public void SetAccessories()
        {
            vehicle.Accessories.Add("Seat Cover");
            vehicle.Accessories.Add("Rear Mirror");
            vehicle.Accessories.Add("Panoramic roof");
        }

        public Vehicle GetVehicle()
        {
            return vehicle;
        }
    }
}
namespace TestConsoleApplication.DesignPatterns.Builder
{
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    public class HeroBuilder : IVehicleBuilder
    {
        Vehicle vehicle = new Vehicle();
        
        public void SetModel()
        {
            vehicle.Model = "Hero";
        }

        public void SetEngine()
        {
            vehicle.Engine = "4 Cylinders";
        }

        public void SetMaxSpeed()
        {
            vehicle.MaxSpeed = "120 km/hr";
        }

        public void SetBody()
        {
            vehicle.Body = "Plastic";
        }

        public void SetAccessories()
        {
            vehicle.Accessories.Add("Seat Cover");
            vehicle.Accessories.Add("Rear Mirror");
        }

        public Vehicle GetVehicle()
        {
            return vehicle;
        }
    }
}
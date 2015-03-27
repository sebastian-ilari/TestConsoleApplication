namespace TestConsoleApplication.DesignPatterns.Builder
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class VehicleCreator
    {
        private readonly IVehicleBuilder builder;

        public VehicleCreator(IVehicleBuilder builder)
        {
            this.builder = builder;
        }

        public void CreateVehicle()
        {
            this.builder.SetModel();
            this.builder.SetEngine();
            this.builder.SetBody();
            this.builder.SetMaxSpeed();
            this.builder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return builder.GetVehicle();
        }
    }
}
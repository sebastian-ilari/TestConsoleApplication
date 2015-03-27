namespace TestConsoleApplication.DesignPatterns.Decorator
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public abstract class VehicleDecorator : IVehicle
    {
        private IVehicle vehicle;

        public VehicleDecorator(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public virtual string Make
        {
            get { return this.vehicle.Make; }
        }

        public virtual string Model
        {
            get { return this.vehicle.Model; }
        }

        public virtual double Price
        {
            get { return this.vehicle.Price; }
        }
    }
}
namespace TestConsoleApplication.DesignPatterns.Builder
{
    /// <summary>
    /// The 'Builder' interface
    /// </summary>
    public interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetMaxSpeed();
        void SetBody();
        void SetAccessories();

        Vehicle GetVehicle();
    }
}
namespace TestConsoleApplication.DesignPatterns.Decorator
{
    /// <summary>
    /// The 'Component' interface
    /// </summary>
    public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        double Price { get; }
    }
}
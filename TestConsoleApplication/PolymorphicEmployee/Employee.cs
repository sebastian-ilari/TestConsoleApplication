
namespace TestConsoleApplication.PolymorphicEmployee
{
    public abstract class Employee
    {
        public abstract bool IsPayday();

        public abstract decimal CalculateTotalSalary();

        public abstract void DeliverSalary(decimal salary);
    }
}
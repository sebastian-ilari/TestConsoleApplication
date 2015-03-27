
namespace TestConsoleApplication.PolymorphicEmployee
{
    interface IEmployeeFactory
    {
        Employee MakeEmployee(EmployeeRecord employeeRecord);
    }
}

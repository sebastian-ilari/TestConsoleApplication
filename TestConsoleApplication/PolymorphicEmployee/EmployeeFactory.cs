using TestConsoleApplication.PolymorphicEmployee.EmployeeImplementations;


namespace TestConsoleApplication.PolymorphicEmployee
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee MakeEmployee(EmployeeRecord employeeRecord)
        {
            switch (employeeRecord.Type)
            {
                case EmployeeType.HOURLY:
                    return new HourlyEmployee(employeeRecord);

                case EmployeeType.MONTHLY:
                    return new MonthlyEmployee(employeeRecord);

                case EmployeeType.YEARLY:
                    return new YearlyEmployee(employeeRecord);

                default:
                    return null;
                //throw new InvalidEmployeeType(r.type);
            }
        }
    }
}
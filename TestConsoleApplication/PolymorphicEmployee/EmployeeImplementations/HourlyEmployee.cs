
namespace TestConsoleApplication.PolymorphicEmployee.EmployeeImplementations
{
    public class HourlyEmployee : Employee
    {
        EmployeeRecord employeeRecord;

        public HourlyEmployee(EmployeeRecord employeeRecord)
        {
            this.employeeRecord = employeeRecord;
            
            this.employeeRecord.Name = "Oracio Hourly Martinez";
            this.employeeRecord = employeeRecord;
            this.employeeRecord.PaymentPerHour = 30;
        }

        public override bool IsPayday()
        {
            return true;
        }

        public override decimal CalculateTotalSalary()
        {
            return this.employeeRecord.PaymentPerHour;
        }

        public override void DeliverSalary(decimal pay)
        {
            
        }
    }
}

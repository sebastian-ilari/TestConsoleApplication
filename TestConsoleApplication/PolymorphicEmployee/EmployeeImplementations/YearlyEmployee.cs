
namespace TestConsoleApplication.PolymorphicEmployee.EmployeeImplementations
{
    public class YearlyEmployee : Employee
    {
        EmployeeRecord employeeRecord;
        
        public YearlyEmployee(EmployeeRecord employeeRecord)
        {
            this.employeeRecord = employeeRecord;
            
            this.employeeRecord.Name = "John Yearly Perez";
            this.employeeRecord = employeeRecord;
            this.employeeRecord.PaymentPerHour = 10;
        }

        public override bool IsPayday()
        {
            return true;
        }

        public override decimal CalculateTotalSalary()
        {
            return this.employeeRecord.PaymentPerHour * 40 * 20 * 12;
        }

        public override void DeliverSalary(decimal pay)
        {
            
        }
    }
}

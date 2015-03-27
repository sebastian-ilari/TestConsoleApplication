
namespace TestConsoleApplication.PolymorphicEmployee.EmployeeImplementations
{
    public class MonthlyEmployee : Employee
    {
        EmployeeRecord employeeRecord;

        public MonthlyEmployee(EmployeeRecord employeeRecord)
        {
            this.employeeRecord = employeeRecord;
            
            this.employeeRecord.Name = "Carlos Monthly Monti";
            this.employeeRecord = employeeRecord;
            this.employeeRecord.PaymentPerHour = 20;
        }
        
        public override bool IsPayday()
        {
            return true;
        }

        public override decimal CalculateTotalSalary()
        {
            return this.employeeRecord.PaymentPerHour * 40 * 20;
        }

        public override void DeliverSalary(decimal pay)
        {
            
        }
    }
}

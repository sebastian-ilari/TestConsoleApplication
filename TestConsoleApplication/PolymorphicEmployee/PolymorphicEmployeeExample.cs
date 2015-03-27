using System;

namespace TestConsoleApplication.PolymorphicEmployee
{
    public class PolymorphicEmployeeExample
    {
        public PolymorphicEmployeeExample()
        {
            EmployeeRecord employeeRecord = PolymorphicEmployeeExample.CreateEmployeeRecordOfType(EmployeeType.YEARLY);
            Employee employee = PolymorphicEmployeeExample.CreateEmployeeFromRecord(employeeRecord);
            PolymorphicEmployeeExample.PrintEmployeePayroll(employee, employeeRecord);
        }

        public static EmployeeRecord CreateEmployeeRecordOfType(EmployeeType employeeType)
        {
            EmployeeRecord employeeRecord = new EmployeeRecord();

            employeeRecord.Type = employeeType;
            
            return employeeRecord;
        }

        public static Employee CreateEmployeeFromRecord(EmployeeRecord employeeRecord)
        {
            EmployeeFactory employeeFactory = new EmployeeFactory();

            return employeeFactory.MakeEmployee(employeeRecord);
        }

        public static void PrintEmployeePayroll(Employee employee, EmployeeRecord employeeRecord)
        {
            Console.WriteLine("Polymorphic Employee example" + Environment.NewLine);
            Console.WriteLine(string.Format("Name: {0}", employeeRecord.Name));
            Console.WriteLine(string.Format("Payment per hour: {0}", employeeRecord.PaymentPerHour));
            Console.WriteLine(string.Format("Total salary: {0}", employee.CalculateTotalSalary().ToString()));
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
        }
    }
}
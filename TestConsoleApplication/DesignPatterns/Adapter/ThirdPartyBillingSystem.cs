using System;
using System.Collections.Generic;

namespace TestConsoleApplication.DesignPatterns.Adapter
{
    /// <summary>
    /// The 'Client' class
    /// </summary>
    public class ThirdPartyBillingSystem
    {
        private ITarget employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        public void PrintEmployeeList()
        {
            List<Employee> employees = employeeSource.GetEmployeeList();
            //To DO: Implement you business logic

            Console.WriteLine("######### Employee List ##########");
            foreach (Employee employee in employees)
            {
                Console.WriteLine("ID: " + employee.Id);
                Console.WriteLine("Name: " + employee.Name);
                Console.WriteLine("Position: " + employee.Position);
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
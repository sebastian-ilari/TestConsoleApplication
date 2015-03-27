using System.Collections.Generic;

namespace TestConsoleApplication.DesignPatterns.Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class EmployeeAdapter : HRSystem, ITarget
    {
        public List<Employee> GetEmployeeList()
        {
            return this.GetEmployeesFromDatabase();
        }
    }
}
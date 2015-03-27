using System.Collections.Generic;

namespace TestConsoleApplication.DesignPatterns.Adapter
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class HRSystem
    {
        public List<Employee> GetEmployeesFromDatabase()
        {
            return new List<Employee>
            {
                new Employee 
                {
                    Id = 100,
                    Name = "James",
                    Position = "Team Leader"
                },

                new Employee 
                {
                    Id = 101,
                    Name = "Patrick",
                    Position = "Developer"
                },

                new Employee 
                {
                    Id = 102,
                    Name = "Andrew",
                    Position = "Developer"
                },

                new Employee 
                {
                    Id = 103,
                    Name = "Melissa",
                    Position = "Tester"
                }
            };
        }
    }
}
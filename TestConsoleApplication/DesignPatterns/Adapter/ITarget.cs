using System.Collections.Generic;

namespace TestConsoleApplication.DesignPatterns.Adapter
{
    /// <summary>
    /// The 'ITarget' interface
    /// </summary>
    public interface ITarget
    {
        List<Employee> GetEmployeeList();
    }
}
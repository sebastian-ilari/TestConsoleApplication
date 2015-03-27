using System.Collections;
using System.Collections.Generic;

namespace TestConsoleApplication.DesignPatterns.Composite
{
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public class Employee : EmployeeBase, IEnumerable<IEmployed>
    {
        private List<IEmployed> subordinates = new List<IEmployed>();

        public void AddSubordinate(IEmployed subordinate)
        {
            this.subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(IEmployed subordinate)
        {
            this.subordinates.Remove(subordinate);
        }

        public IEmployed GetSubordinate(int index)
        {
            return this.subordinates[index];
        }

        public IEnumerator<IEmployed> GetEnumerator()
        {
            foreach (IEmployed subordinate in this.subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
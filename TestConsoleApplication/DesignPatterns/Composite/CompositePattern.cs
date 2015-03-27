using System;

namespace TestConsoleApplication.DesignPatterns.Composite
{
    public class CompositePattern
    {
        public CompositePattern()
        {
            Console.WriteLine("Composite pattern");
            Console.WriteLine(Environment.NewLine);
            
            Employee daniel = new Employee { EmployeeId = 1, Name = "Daniel" };

            Employee leonardo = new Employee { EmployeeId = 2, Name = "Leonardo" };
            Employee marcio = new Employee { EmployeeId = 3, Name = "Marcio" };

            daniel.AddSubordinate(leonardo);
            daniel.AddSubordinate(marcio);

            Employee maximiliano = new Employee { EmployeeId = 4, Name = "Maximiliano" };
            Employee emiliano = new Employee { EmployeeId = 5, Name = "Emiliano" };

            leonardo.AddSubordinate(maximiliano);
            leonardo.AddSubordinate(emiliano);

            Employee nicolas = new Employee { EmployeeId = 6, Name = "Nicolas" };
            Employee carolina = new Employee { EmployeeId = 7, Name = "Carolina" };

            Contractor jesica = new Contractor { EmployeeId = 8, Name = "Jesica" };
            Contractor paula = new Contractor { EmployeeId = 9, Name = "Paula" };

            marcio.AddSubordinate(nicolas);
            marcio.AddSubordinate(carolina);
            marcio.AddSubordinate(jesica);
            marcio.AddSubordinate(paula);

            Console.WriteLine(daniel.ToString());

            foreach (Employee manager in daniel)
            {
                Console.WriteLine("\n\t {0}", manager.ToString());

                foreach (EmployeeBase employee in manager)
                {
                    Console.WriteLine(" \t\t {0}", employee.ToString());
                }
            }

            Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
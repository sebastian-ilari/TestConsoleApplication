using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication.DesignPatterns.Prototype
{
    public class PrototypePattern
    {
        public PrototypePattern()
        {
            Console.WriteLine("Prototype Pattern");
            Console.WriteLine(Environment.NewLine);

            Developer developer = new Developer();
            developer.Name = "Daniel";
            developer.Role = "Team Leader";
            developer.PreferredLanguage = "C#";

            Developer developerCopy = (Developer)developer.Clone();
            developerCopy.Name = "Martin"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(developer.GetDetails());
            Console.WriteLine(developerCopy.GetDetails());

            Typist typist = new Typist();
            typist.Name = "Andres";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Julia";
            typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());

            Console.ReadKey();
        }
    }
}
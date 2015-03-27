using System;

namespace TestConsoleApplication.DesignPatterns.Adapter
{
    public class AdapterPattern
    {
        public AdapterPattern()
        {
            Console.WriteLine("Adapter pattern");
            Console.WriteLine(Environment.NewLine);

            ITarget Itarget = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
            client.PrintEmployeeList();

            Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
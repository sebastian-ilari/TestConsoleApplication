using System;

namespace TestConsoleApplication.DesignPatterns.Proxy
{
    public class ProxyPattern
    {
        public ProxyPattern()
        {
            Console.WriteLine("Proxy Pattern");
            Console.WriteLine(Environment.NewLine);

            ProxyClient proxy = new ProxyClient();
            Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());

            Console.ReadKey();
        }
    }
}
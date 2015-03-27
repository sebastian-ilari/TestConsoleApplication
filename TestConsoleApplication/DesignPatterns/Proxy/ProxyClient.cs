using System;

namespace TestConsoleApplication.DesignPatterns.Proxy
{
    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>
    public class ProxyClient : IClient
    {
        RealClient client;
        
        public ProxyClient()
        {
            Console.WriteLine("Proxy Client: Initialized");
            this.client = new RealClient();
        }

        public string GetData()
        {
            return this.client.GetData();
        }
    }
}
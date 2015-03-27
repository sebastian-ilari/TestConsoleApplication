using System;

namespace TestConsoleApplication.DesignPatterns.Proxy
{
    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    public class RealClient : IClient
    {
        private string data;

        public RealClient()
        {
            this.data = "Sample data from the Real Client"; 
            Console.WriteLine("Real Client: Initialized");
        }

        public string GetData()
        {
            return this.data;
        }
    }
}
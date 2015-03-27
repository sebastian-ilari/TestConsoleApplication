using System;
using System.Collections.Generic;

namespace TestConsoleApplication.DesignPatterns.Builder
{
    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Vehicle
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string MaxSpeed { get; set; }
        public string Body { get; set; }
        public List<string> Accessories { get; set; }

        public Vehicle()
        {
            Accessories = new List<string>();
        }

        public void ShowInfo()
        {
            Console.WriteLine("Model: {0}", this.Model);
            Console.WriteLine("Engine: {0}", this.Engine);
            Console.WriteLine("Body: {0}", this.Body);
            Console.WriteLine("Max Speed: {0}", this.MaxSpeed);
            Console.WriteLine("Accessories:");

            foreach (string accessory in this.Accessories)
            {
                Console.WriteLine("\t{0}", accessory);
            }
        }
    }
}
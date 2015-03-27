using System;

namespace TestConsoleApplication.DesignPatterns.Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class Singleton
    {
        // .NET guarantees thread safety for static initialization
        private static Singleton instance = null;
       
        private string Name { get; set; }        
        private string IP { get; set; }
        private DateTime CreationDate { get; set; }
        
        private Singleton()
        {
            Console.WriteLine("Singleton Intance created");
            Console.WriteLine(Environment.NewLine);

            Name = "Openminder";
            IP = "192.168.1.23";
            CreationDate = DateTime.Now;
        }

        // Lock synchronization object
        private static object syncLock = new object();

        public static Singleton Instance
        {
            get
            {
                lock (syncLock)
                {
                    if (Singleton.instance == null)
                    {
                        Singleton.instance = new Singleton();
                    }

                    return Singleton.instance;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Server Information is: \n    Name = {0} \n    IP = {1} \n    Creation date = {2} \n", 
                                    this.Name, 
                                    this.IP, 
                                    this.CreationDate.ToString());
        }
    }
}
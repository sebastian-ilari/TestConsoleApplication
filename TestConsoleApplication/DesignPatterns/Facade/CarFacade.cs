using System;

namespace TestConsoleApplication.DesignPatterns.Facade
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class CarFacade
    {
        public CarModel model;
        public CarEngine engine;
        public CarBody body;
        public CarAccessories accessories;

        public CarFacade()
        {
            this.model = new CarModel();
            this.engine = new CarEngine();
            this.body = new CarBody();
            this.accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");
            
            this.model.SetModel();
            this.engine.SetEngine();
            this.body.SetBody();
            this.accessories.SetAccessories();

            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}
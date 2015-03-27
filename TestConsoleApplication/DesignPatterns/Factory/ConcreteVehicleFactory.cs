using System;
using System.Collections.Generic;

namespace TestConsoleApplication.DesignPatterns.Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteVehicleFactory : VehicleFactory
    {
        protected Dictionary<VehicleType, Func<IFactory>> vehicleCreator;
        
        public ConcreteVehicleFactory()
        {
            this.vehicleCreator = new Dictionary<VehicleType, Func<IFactory>>();

            this.vehicleCreator.Add(VehicleType.Scooter, NewScooter);
            this.vehicleCreator.Add(VehicleType.Bike, NewBike);
        }

        public override IFactory GetVehicle(VehicleType vehicleType)
        {
            Func<IFactory> func;

            if (this.vehicleCreator.TryGetValue(vehicleType, out func))
            {
                return (IFactory)func.DynamicInvoke();
            }

            throw new ApplicationException(string.Format("Vehicle {0} cannot be created", vehicleType));
        }

        private IFactory NewScooter()
        {
            return new Scooter();
        }

        private IFactory NewBike()
        {
            return new Bike();
        }
    }
}
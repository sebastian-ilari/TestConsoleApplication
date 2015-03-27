using System;

namespace TestConsoleApplication.DesignPatterns.Decorator
{
    public class DecoratorPattern
    {
        public DecoratorPattern()
        {
            Console.WriteLine("Decorator Pattern");
            Console.WriteLine(Environment.NewLine);
            
            // Basic vehicle
            HondaCity car = new HondaCity();

            Console.WriteLine("Honda City base price are : {0}", car.Price);

            // Special offer
            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.Offer = "25 % discount";

            Console.WriteLine("{1} @ Strianese. Special Offer {0} ", offer.Price, offer.Offer);

            Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Suzuki();
            CarDecorator decorator = new OfferPrice(car);

            Console.WriteLine("Style:{0}, Price:{1}, DiscountedPrice:{2}", decorator.BodyStyle, decorator.GetPrice(), decorator.GetDiscountedPrice());
            car = new Hyndai();
            decorator = new OfferPrice(car);

            Console.WriteLine("Style:{0}, Price:{1}, DiscountedPrice:{2}", decorator.BodyStyle, decorator.GetPrice(), decorator.GetDiscountedPrice());
            Console.ReadLine();

        }
    }
}

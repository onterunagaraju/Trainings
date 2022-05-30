using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    internal abstract class CarDecorator : ICar
    {
        private ICar car;
        public CarDecorator(ICar Car)
        {
            car = Car;
            
        }

        public string BodyStyle
        {
            get
            {
                return car.BodyStyle;
            }
        }
        public double GetPrice()
        {
            return car.GetPrice();
        }
        public abstract double GetDiscountedPrice();
    }
}

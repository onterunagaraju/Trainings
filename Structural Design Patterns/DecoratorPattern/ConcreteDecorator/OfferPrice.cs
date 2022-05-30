using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    internal class OfferPrice : CarDecorator
    {
        public OfferPrice(ICar car): base(car)
        {

        }
        public override double GetDiscountedPrice()
        {
            return 0.8 * base.GetPrice();
        }
    }
}

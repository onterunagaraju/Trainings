using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    internal sealed class Suzuki : ICar
    {
        public string BodyStyle
        {
            get
            {
                return "sedan";
            }
        }

        public double GetPrice()
        {
            return 1000000;
        }
    }
}

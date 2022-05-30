using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    internal sealed class Hyndai : ICar
    {
        
        public string BodyStyle
        {
            get
            {
                return "HatchBack";
            }
        }

        public double GetPrice()
        {
            return 800000;
        }
    }
}

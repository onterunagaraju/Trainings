using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Component
{
    internal interface ICar
    {
        string BodyStyle { get; }
        double GetPrice();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_FactoryPattern
{
    internal class Add : ICaluculate
    {
        public void Calculate(int a, int b)
        {
            Console.WriteLine("addition of two numbers: {0}",a+b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;  
            int b = 2;
            CalculateFactory  factory = new CalculateFactory();
            ICaluculate addition = factory.GetInstance("add");
            addition.Calculate(a, b);
            Console.ReadLine();
        }
    }
}

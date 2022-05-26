using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_FactoryPattern
{
    internal class CalculateFactory
    {
        ICaluculate obj = null;
        public ICaluculate GetInstance(string type)
        {
            if (type.Equals("add"))
            {
                obj = new Add();
            }
            else if (type.Equals("subtract"))
            {
                obj = new Subtract();
            }
            else if (type.Equals("divide"))
            {
                obj = new Divide();
            }
            else
            {
                Console.WriteLine("Enter valid operation");
            }

            return obj;
        }
    }
}

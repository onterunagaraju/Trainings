using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Strategy1 : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("Called Strategy1 Algorithm");
        }
    }
}

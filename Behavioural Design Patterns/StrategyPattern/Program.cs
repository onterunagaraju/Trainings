using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context;
            context = new Context(new Strategy1());
            context.CallStrategyAlgo();

            context = new Context(new Strategy2());
            context.CallStrategyAlgo();

            context = new Context(new Strategy3());
            context.CallStrategyAlgo();

            Console.ReadLine();

        }
    }
}

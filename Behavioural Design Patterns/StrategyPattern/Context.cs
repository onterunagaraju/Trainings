using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Context
    {
        private Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void CallStrategyAlgo()
        {
            strategy.Algorithm();
        }
    }
}

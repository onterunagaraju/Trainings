using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal abstract class ElctronicGoods
    {
        protected IState state;
        public ElctronicGoods(IState state)
        {
            this.state = state;
        }

        public abstract void MoveToCurrentState();
    }
}

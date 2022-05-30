using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class Television : ElctronicGoods
    {
        public Television(IState state) : base(state)
        {
        }

        public override void MoveToCurrentState()
        {
            Console.WriteLine("\nTelevision is functioning at : ");
            state.MoveState();
        }
    }
}

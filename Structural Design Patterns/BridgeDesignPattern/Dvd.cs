using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class Dvd : ElctronicGoods
    {
        public Dvd(IState state) : base(state)
        {
        }

        public override void MoveToCurrentState()
        {
            Console.WriteLine("\nDVD is functioning at : ");
            state.MoveState();
        }
    }
}

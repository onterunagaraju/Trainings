using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class OffState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("Off state");
        }
    }
}

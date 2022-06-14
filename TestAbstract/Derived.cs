using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstract
{
    internal class Derived : TestAbstract
    {
        public override void Show()
        {
            Console.WriteLine("Hello override");
        }
    }
}

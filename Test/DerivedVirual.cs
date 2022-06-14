using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class DerivedVirual: Virtual
    {
        public override void Show()
        {
            Console.WriteLine("Hello overide");
        }
    }
}

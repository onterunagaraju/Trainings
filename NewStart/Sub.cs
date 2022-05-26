using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStart
{
    internal class Sub : Super
    {
        public void me5()
        {
            Console.WriteLine("child own method");
        }

        public override void me3()
        {
            Console.WriteLine("in child me3");
        }
    }
}

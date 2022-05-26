using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStart
{
    internal class Super
    {
        public void me1()
        {
            Console.WriteLine("in me1");
        }

        public void me2()
        {
            Console.WriteLine("in me2");
        }

        public virtual void me3()
        {
            Console.WriteLine("in me3");
        }
    }
}

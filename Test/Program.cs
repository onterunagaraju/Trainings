using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Virtual v1 = new Virtual();
            DerivedVirual v2 = new DerivedVirual();
            v1.Show();
            v2.Show();
            Console.ReadLine();
        }
    }
}

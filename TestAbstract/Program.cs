using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestAbstract testAbstract = new Derived();
            testAbstract.Show();
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer1 = Printer.GetInstance();
            Printer printer2 = Printer.GetInstance();
            Console.WriteLine(printer1.GetHashCode());
            Console.WriteLine(printer2.GetHashCode());
            Console.ReadLine();
        }
    }
}

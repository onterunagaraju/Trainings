using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemplateAbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            TemplateAbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();

            Console.ReadLine();
        }
    }
}

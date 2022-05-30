using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    internal class ConcreteClassB :TemplateAbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ClassB's PrimitiveOperation 1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ClassB's PrimitiveOperation 2");
        }
    
    }
}

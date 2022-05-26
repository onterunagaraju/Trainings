using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Singleton
{
    internal class Printer
    {
        private static Printer printer;
        private Printer()
        {

        }

        public static Printer GetInstance()
        {
            if(printer == null)
            {
                printer = new Printer();
            }
            return printer;
        }
    }
}

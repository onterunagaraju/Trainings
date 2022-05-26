using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP_ISP.Solution
{
    internal class Receptionist : IActivities
    {
        public void BalanceEnquiry()
        {
            Console.WriteLine("Balence Details");
        }

        public void GetAccDetails()
        {
            Console.WriteLine("Account Details");
        }
    }
}

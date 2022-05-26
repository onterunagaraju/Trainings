using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class LoanService
    {
        public void GetLoanIntrestInfo(string loanType)
        {
            if (loanType.Equals("homeloan"))
            {
                Console.WriteLine("Home loan Intrest");
            }
            if (loanType.Equals("personalloan"))
            {
                Console.WriteLine("Personal loan Intrest");
            }
            if (loanType.Equals("carloan"))
            {
                Console.WriteLine("Car loan Intrest");
            }
        }
    }
}

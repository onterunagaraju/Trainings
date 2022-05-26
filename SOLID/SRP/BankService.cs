using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class BankService
    {
        public long Deposit(long amount, string accoutNo)
        {
            // deposit amount
            Console.WriteLine("Depositing money");
            return 0;
        }
        public long WithDraw(long amount, string accoutNo)
        {
            // withdraw amount
            Console.WriteLine("Withdrawing money");
            return 0;
        }

        // moved to PrinterService Class
        /*public void PrintPassbook()
        {
            Console.WriteLine("Printing passbook");
        }*/

        // moved to LoanService Class
        /*public void GetLoanIntrestInfo(string loanType)
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
        }*/


        // moved to NotificationService Class
       /* public void SendOTP(string medium)
        {
            if (medium.Equals("email"))
            {
                Console.WriteLine("OTP through email");
            }

        }*/
    }
}

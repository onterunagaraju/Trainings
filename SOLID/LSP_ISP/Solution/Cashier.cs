using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP_ISP.Solution
{
    internal class Cashier : ICashierActivities, IActivities
    {
        public void BalanceEnquiry()
        {
            Console.WriteLine("Balance Details");
        }

        public void DepositActivity()
        {
            Console.WriteLine("Money Deposit Activity");
        }

        public void GetAccDetails()
        {
            Console.WriteLine("Account Details");
        }

        public void WithdrawActivity()
        {
            Console.WriteLine("Money Withdraw Activity");
        }
    }
}

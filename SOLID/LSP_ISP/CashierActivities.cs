using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP_ISP
{
    internal class CashierActivities : Activities
    {
        public override void BalanceEnquiry()
        {
            Console.WriteLine("Balence details");
        }

        public override void DepositActivity()
        {
            Console.WriteLine("Money Deposit Activity");
        }

        public override void GetAccDetails()
        {
            Console.WriteLine("Account Details");
        }

        public override void WithdrawActivity()
        {
            Console.WriteLine("Money Withdrae Activity");
        }
    }
}

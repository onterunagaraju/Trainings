using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP_ISP
{
    internal class RecepionistActivities : Activities
    {
        // it's voilating ISP and 
        public override void BalanceEnquiry()
        {
            Console.WriteLine("Balance details");
        }

        public override void DepositActivity()
        {
            throw new NotImplementedException();
        }

        public override void GetAccDetails()
        {
            Console.WriteLine("Account details");
        }

        public override void WithdrawActivity()
        {
            throw new NotImplementedException();
        }
    }
}

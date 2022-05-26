using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP_ISP
{
    internal abstract class Activities
    {
        public abstract void GetAccDetails();
        public abstract void BalanceEnquiry();
        public abstract void DepositActivity();
        public abstract void WithdrawActivity();
        // Class obj = new Class();
        // Superclass obj = new Subclass();
        // Activities activity1 = new CashierActivities();
        // activity1.BalanceEnquiry();
    }
}

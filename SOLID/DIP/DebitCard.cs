using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class DebitCard : IBankCard
    {
        public void DoTransaction(long amount)
        {
            Console.WriteLine("Transaction through debit card");
        }
    }
}

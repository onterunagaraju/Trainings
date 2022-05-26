using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class CardforTransaction
    {
        // This is tightly coupled if you want to do transaction with credit card then you need to 
        // change lot of code
        private IBankCard bankCard;
        public CardforTransaction(IBankCard bankCard)
        {
            this.bankCard =bankCard; 
        }

        public void DoPurchasewithCard(long amount)
        {
            bankCard.DoTransaction(amount);
        }

        // You need to write below code for using creditcard

        /*private CreditCard creditCard;
        public CardforTransaction(CreditCard creditCard)
        {
            this.creditCard = creditCard;
        }

        public void DoPurchasewithCard(long amount)
        {
            creditCard.DoTransaction(amount);
        }*/
    }
}

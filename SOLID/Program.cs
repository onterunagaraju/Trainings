using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DIP.CardforTransaction card = new DIP.CardforTransaction(new DIP.CreditCard());
            card.DoPurchasewithCard(100);

             
            // Single responsibility principle
            SRP.BankService bankService = new SRP.BankService();
            bankService.Deposit(19, "i8");
            Console.ReadLine();

            
        }
    }
}

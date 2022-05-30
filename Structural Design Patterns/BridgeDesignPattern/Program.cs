using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dealing with Telivision");
            ElctronicGoods eitem = new Television(new OnState());
            eitem.MoveToCurrentState();

            Console.WriteLine("\nDealing with DVD");
            ElctronicGoods goods = new Dvd(new OffState());
            goods.MoveToCurrentState();
            Console.ReadLine();

        }

    }
}

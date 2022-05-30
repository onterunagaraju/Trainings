using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicCar nano_base = new Nano("Red Nano") { Price = 100000 };
            BasicCar ford_base = new Ford("Blue Ford") { Price = 500000 };
            BasicCar bc1;
            //Nano
            bc1 = nano_base.Clone();
            bc1.Price = nano_base.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1} ", bc1.ModelName, bc1.Price);

            bc1 = ford_base.Clone();
            bc1.Price = ford_base.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1} ", bc1.ModelName, bc1.Price);

            Console.ReadLine(); 
        }
    }
}

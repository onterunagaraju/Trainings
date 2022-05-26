using DP_AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client businessPerson = new Client(new ElegantClothesFactory());
            Console.WriteLine(businessPerson.DescribeTheClothes());

            Client student = new Client(new CasualClothesFactory());
            Console.WriteLine(student.DescribeTheClothes());
            Console.ReadLine();
        }
    }
}

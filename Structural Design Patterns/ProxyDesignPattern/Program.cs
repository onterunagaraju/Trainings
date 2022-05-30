using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy(new ConcreteService());
            proxy.Login(15);
            proxy.Login(29);
            Console.ReadLine();
        }
    }
}

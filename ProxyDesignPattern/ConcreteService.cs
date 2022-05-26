using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class ConcreteService : IService
    {
        public void Login(int age)
        {
            Console.WriteLine("You are logged in. You are age is "+ age);
        }
    }
}

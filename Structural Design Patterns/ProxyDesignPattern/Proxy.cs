using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class Proxy : IService
    {
        private IService service;
        public Proxy(IService service)
        {
            this.service = service;
        }

        public void Login(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("You are too yoing");
            }
            else
            {
                service.Login(age); 
            }
        }
    }
}

using DP_AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory
{
    internal class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trousers;
        public Client(ClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();
        }

        public string DescribeTheClothes()
        {
            return $"Today I'm in {_shirt.GetType().Name} and {_trousers.GetType().Name}";
        }
    }
}

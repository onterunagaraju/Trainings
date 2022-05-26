using DP_AbstractFactory.AbstractProducts;
using DP_AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Factories
{
    internal class CasualClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new Jeans();
        }
    }
}

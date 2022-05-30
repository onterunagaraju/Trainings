using DP_AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory
{
    internal abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Trousers CreateTrousers();

    }
}

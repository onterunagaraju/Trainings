using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    internal class Circle : IShape
    {
        private string color;
        public Circle(string color)
        {
            this.color = color;
        }

        public void draw()
        {
            Console.WriteLine("Circle drawn in the color "+color);
        }
    }
}

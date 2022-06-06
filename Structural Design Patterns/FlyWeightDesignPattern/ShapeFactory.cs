using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    internal class ShapeFactory
    {
        private static Dictionary<string, Circle> d = new Dictionary<string, Circle>();
        public static IShape getCircle(String color)
        {
            IShape circle;
            if (d.ContainsKey(color))
            {
                circle = d[color];
            }

            else
            {
                circle = new Circle(color);
                d.Add(color, (Circle)circle);
                Console.WriteLine("Creating circle of color : " + color);
            }
            return circle;
        }
    }
}

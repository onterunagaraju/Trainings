using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = (Circle)ShapeFactory.getCircle("red");
            circle.draw();
            Circle circle1 = (Circle)ShapeFactory.getCircle("red");
            circle.draw();
            Circle circle2 = (Circle)ShapeFactory.getCircle("green");
            circle.draw();
            Console.ReadLine();
        }
    }
}

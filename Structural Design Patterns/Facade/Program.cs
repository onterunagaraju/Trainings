using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeMakerFacade circle = new ShapeMakerFacade(new Circle());
            circle.DrawShape();
            ShapeMakerFacade triangle = new ShapeMakerFacade(new Triangle());
            triangle.DrawShape();
            ShapeMakerFacade rectangle = new ShapeMakerFacade(new Rectangle());
            rectangle.DrawShape();
            Console.ReadLine();
        }
    }
}

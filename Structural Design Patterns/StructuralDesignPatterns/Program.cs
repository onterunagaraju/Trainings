using StructuralDesignPatterns.AdapterPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rect r = new Rect(20, 10);
            Console.WriteLine("\nArea of Rectangle is :{0} Square unit",r.CalculateAreaOfRectangle());
            Triangle t = new Triangle(20, 10);
            Console.WriteLine("\nArea of Triangle without Adapter is :{0} Square unit", t.CalculateAreaOfTriangle());
            IRect adapter = new TriangleAdapter(t);
            //Passing a Triangle instead of a Rectangle
            Console.WriteLine("\nArea of Triangle with Triangle Adapter is :{0} Square unit", GetArea(adapter));
        }
        private static double GetArea(IRect r)
        {
            r.AboutRectangle();
            return r.CalculateAreaOfRectangle();
        }
    }
}

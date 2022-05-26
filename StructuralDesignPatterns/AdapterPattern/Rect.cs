using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AdapterPattern
{
    internal class Rect: IRect
    {
        public double Length;
        public double Width;
        public Rect(double l, double w)
        {
            this.Length = l;
            this.Width = w;
        }
        public double CalculateAreaOfRectangle()
        {
            return Length * Width;
        }
        public void AboutRectangle()
        {
            Console.WriteLine("\nActually, I am a Rectangle\n");
        }
    }
}

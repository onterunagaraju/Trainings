using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AdapterPattern
{
    internal class TriangleAdapter : IRect
    {
        private Triangle triangle;
        public TriangleAdapter(Triangle t)
        {
            this.triangle = t;
        }
        public void AboutRectangle()
        {
            triangle.AboutTriangle();
        }
        public double CalculateAreaOfRectangle()
        {
            return triangle.CalculateAreaOfTriangle();
        }
    }
}

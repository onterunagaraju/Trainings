﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AdapterPattern
{
    internal class Triangle: ITriangle
    {
        public double BaseLength;//base
        public double Height;//height
        public Triangle(double b, double h)
        {
            this.BaseLength = b;
            this.Height = h;
        }
        public double CalculateAreaOfTriangle()
        {
            return 0.5 * BaseLength * Height;
        }
        public void AboutTriangle()
        {
            Console.WriteLine("\nActually, I am a Triangle\n");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Reactangle drawn");
        }
    }
}

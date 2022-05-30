using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class ShapeMakerFacade
    {
        private IShape shape;
        public ShapeMakerFacade(IShape shape)
        {
            this.shape = shape;
        }

        public void DrawShape()
        {
            shape.draw();
        }
    }
}

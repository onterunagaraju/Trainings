using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterater
{
    internal interface IIterator
    {
         bool hasNext();
         string next();
    }
}

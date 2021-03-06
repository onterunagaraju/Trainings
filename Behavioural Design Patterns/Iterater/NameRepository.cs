using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterater
{
    internal class NameRepository : IContainer
    {
        public static string[] names = { "Robert", "John", "Julie", "Lora" };
        public IIterator getIterator()
        {
            return new NameIterator();
        }
        private class NameIterator : IIterator
        {

            int index;


            public bool hasNext()
            {

                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }


            public string next()
            {

                if (this.hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}

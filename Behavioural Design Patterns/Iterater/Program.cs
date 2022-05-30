using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NameRepository namesRepository = new NameRepository();

            for (IIterator iter = namesRepository.getIterator(); iter.hasNext();)
            {
                string name = Convert.ToString(iter.next());
                Console.WriteLine("Name : " + name);
            }
            Console.ReadLine();
        }
    }
}

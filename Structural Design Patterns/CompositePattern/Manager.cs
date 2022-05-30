using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Manager : IEmployee
    {
        public List<IEmployee> subOrdinates;
        public string name;
        public string department;
        public Manager(string name, string department)
        {
            this.name = name;
            this.department = department;
            subOrdinates = new List<IEmployee>();
        }

        public void GetDetails(int index)
        {
            Console.WriteLine("{0}+ Name:{1}, Department:{2} --- Manager(Composite)", new String('-',index),this.name, this.department);
            foreach (IEmployee employee in subOrdinates)
            {
                employee.GetDetails(index+1);
            }
        }
    }
}

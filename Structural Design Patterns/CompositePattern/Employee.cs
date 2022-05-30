using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Employee : IEmployee
    {
        public string name;
        public string department;
        public Employee(string name, string department)
        {
            this.name = name;
            this.department = department;
        }
        
        public void GetDetails(int index)
        {
            Console.WriteLine("{0}- Name:{1} Department:{2} --Leaf",new String('-',index),this.name,this.department);
        }
    }
}

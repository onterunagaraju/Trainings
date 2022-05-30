using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee Nag = new Employee("Nag", "Techincal");
            IEmployee Raj= new Employee("Raj", "Techincal");
            IEmployee Ravi = new Employee("Ravi", "HR");
            IEmployee Vamsi = new Employee("Vamsi", "HR");

            IEmployee Ammu = new Manager("Ammu", "Technical") { subOrdinates = { Nag, Raj } };
            IEmployee Hari = new Manager("Hari", "HR") { subOrdinates = { Ravi, Vamsi } };

            IEmployee Bob = new Manager("Bob", "Head") { subOrdinates = { Ammu, Hari } };

            Bob.GetDetails(1);
            Console.ReadLine();
        }
    }
}

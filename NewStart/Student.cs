using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStart
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string name, string major, double gpa)
        {
            this.name = name;
            this.major = major;
            this.gpa = gpa;
        }

        public bool HasPassed()
        {
            if (gpa > 2.0) return true;
            return false;
        }
    }
}

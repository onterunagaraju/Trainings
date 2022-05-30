﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
            
            Console.ReadKey();
        }
    }
}

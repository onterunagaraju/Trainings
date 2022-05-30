﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class ConcreteObserver: Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;
        // Constructor
        public ConcreteObserver(
            ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }
        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}",
                name, observerState);
        }
        // Gets or sets subject
        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}

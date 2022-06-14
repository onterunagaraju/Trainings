using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue(5);

            Q.Enqueue(10);
            Q.Enqueue(20);
            Q.Enqueue(30);
            Q.Enqueue(40);
            Q.Enqueue(50);

            Console.WriteLine("Items are : ");
            Q.Display();

            Q.Dequeue();
            Q.Dequeue();
            Q.Peek();
            Q.IsEmpty();
            Console.WriteLine("Items are : ");
            Q.Display();
            Q.Dequeue();
            Q.Dequeue();
            Q.Dequeue();
            Q.Display();
            Q.IsEmpty();
            Console.ReadLine();
        }
    }
}

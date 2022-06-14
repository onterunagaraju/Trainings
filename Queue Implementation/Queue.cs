using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation
{
    internal class Queue
    {
        private int[] elements;
        private int front;
        private int rear;
        private int max;
        

        public Queue(int size)
        {
            elements = new int[size];
            front = -1;
            rear = -1;
            max = size;
        }

        public void Enqueue(int item)
        {
            if (rear == max)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                elements[rear+1] = item;
                rear++;
            }
        }

        public int Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("deleted element is: " + elements[front+1]);
                front++;
                return elements[front];
            }
        }

        public void Display()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front+1; i <= rear; i++)
                {
                    Console.WriteLine("" + elements[i]);
                }
            }
        }
        public void Peek()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                Console.WriteLine("The peek element is "+ elements[front+1]);
            }
        }
        public void IsEmpty()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                Console.WriteLine("Queue is not empty");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.dsa
{

    class QueueImp
    {
        public int[] arr;
        public int front;
        public int rear;
        public QueueImp(int size)
        {
            arr = new int[size];
            front = 0;
            rear = 0;
        }

        public void enqueue(int value)
        {
            if (rear == arr.Length)
            {
                Console.WriteLine("queue is full");
            }
            else
            {
                arr[rear] = value;
                rear++;
            }
        }

        public void dequeue()
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("queue is empty");

            }
            else
            {
                arr[front] = 0;
                front++;
            }
        }

        public int peek()
        {
            if (arr.Length == 0)
            {
                return -1;
            }
            else
            {
                return arr[front];
            }
        }

        public void display()
        {
            for (int i = front; i < rear; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }


    }

    internal class Queue
    {
        public static void Main(string[] args)
        {

            QueueImp queue = new QueueImp(5);
            queue.enqueue(10);
            queue.enqueue(20);
            queue.enqueue(30);
            queue.enqueue(40);
            queue.dequeue();
            queue.display();
            Console.WriteLine("top element is: "+queue.peek());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.dsa 
{
    class StackImp
    {
        public int[] arr;
        public int top;
        public StackImp(int size)
        {
            arr = new int[size];
            top = 0;
        }
        public void push(int value)
        {
            if (top < arr.Length)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                arr[top] = value;
                top++;
            }
        }
        public void pop()
        {
            if (top == 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                arr[top - 1] = 0;
                top--;
            }
        }

        public void peek()
        {
            if (top == arr.Length)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                Console.WriteLine(arr[top - 1]);

            }
        }
        public void display()
        {
            for (int i = top - 1; i >= 0; i--)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine(arr[i]);
                }

            }
        }
    }
    internal class Stack
    {
        public static void Main(string[] args)
        {
            StackImp stack = new StackImp(5);
            stack.push(10);
            stack.push(20);
            stack.push(30);
            stack.push(40);
            stack.pop();
            stack.display();
            stack.peek();
        }
    }
}

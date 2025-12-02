using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.CollectionLibraries
{
    internal class Stack
    {
        public static void Main(string[] args)
        {
            Stack<int> stack=new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();
            stack.Peek();

            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
        } 
    }
}

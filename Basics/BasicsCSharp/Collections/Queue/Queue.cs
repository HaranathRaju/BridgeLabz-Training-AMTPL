using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.CollectionLibraries
{
    internal class Queue
    {
        public static void Main(string[] args)
        {
            Queue<int> queue=new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);   
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue();
            queue.Peek();

            foreach(int i in queue)
            {
                Console.WriteLine(i);
            }

        }
    }
}

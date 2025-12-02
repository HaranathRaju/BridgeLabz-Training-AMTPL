using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.CollectionLibraries
{
    internal class LinkedList
    {
        public static void Main(string[] args)
        {
            LinkedList<int> l = new LinkedList<int>();
            l.AddFirst(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);   
            l.AddLast(5);
            l.RemoveFirst();
            l.RemoveLast();
            
            foreach(int i in l)
            {
                Console.WriteLine(i);   
            }
        }
    }
}

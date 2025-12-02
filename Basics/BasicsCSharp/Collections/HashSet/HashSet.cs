using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.CollectionLibraries
{
    internal class HashSet
    {
        public static void Main (string[] args)
        {
            HashSet<int> set=new HashSet<int> ();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(3);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Remove(3);

            foreach (int i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}

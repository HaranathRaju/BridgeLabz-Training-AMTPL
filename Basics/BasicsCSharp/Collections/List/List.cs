using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.CollectionLibraries
{
    internal class List
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() {1,2,3};
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Remove(6);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}

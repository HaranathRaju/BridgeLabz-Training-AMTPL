using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.CollectionLibraries
{
    internal class Dictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<int,int> d=new Dictionary<int,int>();
            d.Add(1, 2);
            d.Add(2, 3);
            d.Add(3, 4);

            foreach(KeyValuePair<int,int> i in d)
            {
                Console.WriteLine(i.Key + " : " + i.Value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.AdvanceCSharp.Delegates
{
    internal class GenericDelegate
    {
        public static void Main(string[] args)
        {

            Func<int, int, int> d = (a, b) => a + b;
            Console.WriteLine(d(1, 3));

            Action<int> d2 = n => Console.WriteLine(n);
            d2(2);

            Predicate<int> d3 = n => n % 2 == 0;
            Console.WriteLine(d3(2));

        }
         
    }
}

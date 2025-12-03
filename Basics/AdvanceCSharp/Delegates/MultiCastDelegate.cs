using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.AdvanceCSharp.Delegates
{

    public delegate int method(int a, int b);

    internal class MultiCastDelegate
    {
        public static void Main(string[] args)
        {

            method m = new method(add);
            method m2=new method(sub);
            Console.WriteLine(m(2, 4));
            Console.WriteLine(m2(5, 3));

        }

        public static int add(int a,int b)
        {
            return a + b;
        }
        public static int sub(int a ,int b)
        {
            return a - b;
        }

    }
}

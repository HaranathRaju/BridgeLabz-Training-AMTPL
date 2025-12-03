using System;
using System.Collections.Generic;



public delegate void method1(string name);

namespace Basics.AdvanceCSharp.Delegates
{
    internal class SingleCastDelegate
    {
        public static void Main(string[] args)
        {

            method1 m = hello;
            m("hi");

        }
        public static void  hello(string name)
        {
            Console.WriteLine(name);
        }
    }
}

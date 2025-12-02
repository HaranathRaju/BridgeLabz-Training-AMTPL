using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface Bird 
{
    void eat();
    void sleep();

}

class Pegion : Bird { 
    public void eat()
    {
        Console.WriteLine("pegion eats");
    }
    public void sleep()
    {
        Console.WriteLine("pegion sleeps");
    }
}

namespace Basics.Oops
{
    internal class Interface
    {
        public static void Main(string[] args)
        {
            Pegion p=new Pegion();
            p.eat();
            p.sleep();
        }
    }
}

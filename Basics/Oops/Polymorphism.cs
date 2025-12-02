using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Vehicle
{
    public virtual void start()
    {
        Console.WriteLine("vehicle starts");
    }
}

class Bike : Vehicle
{
    public override void start()
    {
        Console.WriteLine("bike starts");
    }
}

class Car : Vehicle
{
    public override void start() {
        Console.WriteLine("car started");
    }
}

namespace Basics.Oops
{
    internal class Polymorphism
    {
        public static void Main(string[] args)
        {
            Vehicle b = new Bike();
            Vehicle C = new Car();
            b.start();
            C.start();

        }
    }
}

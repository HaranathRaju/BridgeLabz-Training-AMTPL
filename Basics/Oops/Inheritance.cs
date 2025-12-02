using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    public string name;
    public Animal(string name)
    {
        this.name = name;
    }
    public   void sleep()
    {
        Console.WriteLine(name+" is sleeping");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name)
    {

    }
    public  void eat()
    {
        Console.WriteLine(name + " is eating");
    }
}



namespace Basics.Oops
{
    internal class Inheritance
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog("puppy");
            d.eat();
            d.sleep();

        }
    }
}

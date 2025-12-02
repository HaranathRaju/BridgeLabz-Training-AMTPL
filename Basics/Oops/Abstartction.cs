using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class Shape
{
    public abstract  void area();
    
   
}

class Square : Shape 
{
    public int side;
    public Square(int side)
    {
        this.side = side;
    }

    public override void area()
    {
        Console.WriteLine(side * side);
    }
}

class Rectangle : Shape
{
    public int length;
    public int breadth;
    public Rectangle (int length, int breadth)
    {
        this.length = length;
        this.breadth = breadth;

    }

    public override void area()
    {
        Console.WriteLine(length*breadth);
    }
}


namespace Basics.Oops
{
    internal class Abstartction
    {
        public static void Main(string[] args)
        {

            Shape s = new Square(4);
            Shape r=new Rectangle(4,4);

            s.area();
            r.area();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.AdvanceCSharp.Events
{

    public delegate void Notify();

    public class process 
    {
        public event Notify On;

        public void Start()
        {
            Console.WriteLine("process is completed");
        }

    }
    internal class Event
    {
        public static void Main(string[] args)
        {
            process p=new process();
            p.On += Handler;
            p.Start();

        }
        public static void Handler()
        {
            Console.WriteLine("Process Completed Event Received!");
        }
    }
}

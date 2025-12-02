
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.AdvanceCSharp.Linq
{
    class Student
    {
        public int id;
        public String name;
        public int score;
        public Student(int id, String name, int score)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }
        public override string ToString()
        {
            return "id: " + id + " name: " + name + " score: " + score;
        }
    }
    internal class StudentResultProcessing
    {
        public static void Main(string [] args)
        {
            List<Student> students = new List<Student>() {
            new Student(1, "Surya", 56),
            new Student(2, "Suhas", 68),
            new Student(3, "Anand", 28),
            new Student(4, "tarun", 75),
            new Student(5, "hemanth", 42)
            };

            var firststudent = students.Where(n => n.name.StartsWith("S"))
            .FirstOrDefault();
            Console.WriteLine(firststudent);

            var averagescore = students.Select(n => n.score)
            .Average();

            Console.WriteLine(averagescore);

            bool allpassed = students.All(n => n.score > 35);

            Console.WriteLine(allpassed);
        }
    }
}

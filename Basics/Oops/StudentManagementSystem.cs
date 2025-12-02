using System;


namespace ObjectOrientedProgramming.problems
{
    class Student
    {
        public static string UniversityName = "Oxford University";
        public static int TotalStudents = 0;

        public string Name;
        public string Grade;

        public readonly string RollNumber;

        public Student(string Name, string RollNumber, string Grade)
        {
            this.Name = Name;
            this.RollNumber = RollNumber;
            this.Grade = Grade;

            TotalStudents++; 
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students Enrolled: " + TotalStudents);
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine("University Name: " + UniversityName);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Grade: " + Grade);
        }
    }
    internal class StudentManagementSystem
    {
        public static void Main(string[] args)
        {

            Student s1 = new Student("John", "R101", "A");
            Student s2 = new Student("Alice", "R102", "B");

            Student.DisplayTotalStudents();

            if (s1 is Student)
            {
                s1.DisplayStudentInfo();
            }

            if (s2 is Student)
            {
                s2.DisplayStudentInfo();
            }

        }
    }
}

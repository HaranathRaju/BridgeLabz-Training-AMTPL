
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.AdvanceCSharp.Linq
{
    class Employee
    {
        public int id;
        public String name;
        public String department;
        public double salary;

        public Employee(int id, String name, String department, double salary)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "id :" + id + " name: " + name + " department: " + department + " salary: " + salary;
        }

    }
    internal class EmployeePerformanceSystem
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee e1 = new Employee(1, "tarun", "It", 100000);
            Employee e2 = new Employee(2, "yash", "Hr", 40000);
            Employee e3 = new Employee(3, "manoj", "It", 70000);
            Employee e4 = new Employee(4, "haridhar", "Hr", 30000);
            Employee e5 = new Employee(5, "mahidhar", "Hr", 60000);
            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            employees.Add(e4);
            employees.Add(e5);

            var itemployees = employees.Where(n => n.department.Equals("It") && n.salary > 50000);

            foreach (Employee i in itemployees)
            {
                Console.WriteLine(i);
            }

            var count = employees.Where(n => n.department.Equals("Hr"))
                .Count();
            Console.WriteLine(count);

            var highsalary = employees.Max(n => n.salary);

            var maxemployee = employees.Where(n => n.salary == highsalary);

            foreach (Employee i in maxemployee)
            {
                Console.WriteLine(i);
            }


        }
    }
}

using System;


namespace ObjectOrientedProgramming.problems
{
    class Employee
    {
        public static string CompanyName = "Apexon";
        public static int TotalEmployees = 0;
        public string name;
        public readonly string id;
        public string designation;

        public Employee(string name, string id, string designation)
        {
            TotalEmployees += 1;
            this.name = name;
            this.id = id;
            this.designation = designation;
        }

        public static int GetTotalEmployees()
        {
            return TotalEmployees;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Company Name: " + CompanyName);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Designation: " + designation);
        }
    }


    internal class EmployeeManagementSystem
    {
        public static void Main(string[] args)
        {
            Employee emp1=new Employee("Alice", "E001", "Software Engineer");
            Employee emp2 = new Employee("Bob", "E002", "Product Manager");
            Console.WriteLine("Company Name: " + Employee.CompanyName);
            Console.WriteLine("Total Employees: " + Employee.GetTotalEmployees());
            if (emp1 is Employee)
            {
                emp1.DisplayEmployeeInfo();
            }
            if (emp2 is Employee)
            {
                emp2.DisplayEmployeeInfo();
            }

        }
    }
}

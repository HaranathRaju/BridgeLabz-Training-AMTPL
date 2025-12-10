using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.AdvanceCSharp.DateTimeClass
{

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Login { get; set; }
        public DateTime Logout { get; set; }
        public DateTime Birthdate { get; set; }

        public Employee(int id, string name, DateTime login, DateTime logout, DateTime birthdate)
        {
            this.Id = id;
            this.Name = name;
            this.Login = login;
            this.Logout = logout;
            this.Birthdate = birthdate;
        }

        public override string ToString()
        {
            return $"name : {Name}";
        }

    }

    internal class EmployeeManagement
    {
        public static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            Employee e1 = new Employee(
                1,
                "Haranath",
                new DateTime(2025, 12, 3, 9, 15, 0),
                new DateTime(2025, 12, 3, 19, 30, 0),
                new DateTime(1999, 5, 21)
            );

            Employee e2 = new Employee(
                2,
                "Anu",
                new DateTime(2025, 12, 3, 10, 00, 0),
                new DateTime(2025, 12, 3, 18, 15, 0),
                new DateTime(2000, 11, 12)
            );

            Employee e3 = new Employee(
                3,
                "Kiran",
                new DateTime(2025, 12, 2, 8, 45, 0),
                new DateTime(2025, 12, 2, 16, 10, 0),
                new DateTime(1995, 1, 10)
            );

            Employee e4 = new Employee(
                4,
                "Priya",
                new DateTime(2025, 12, 1, 9, 00, 0),
                new DateTime(2025, 12, 1, 17, 00, 0),
                new DateTime(1998, 7, 8)
            );

            Employee e5 = new Employee(
                5,
                "Vikram",
                new DateTime(2025, 12, 3, 11, 20, 0),
                new DateTime(2025, 12, 3, 19, 40, 0),
                new DateTime(1997, 12, 3)
            );

            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            employees.Add(e4);
            employees.Add(e5);

            var loggedafter10 = employees.Where(n => n.Login.TimeOfDay > new TimeSpan(10, 0, 0)).ToList();

            foreach (Employee i in loggedafter10)
            {
                Console.WriteLine(i);
            }



            var december = employees.Where(n => n.Birthdate.Month == 11);

            foreach (Employee i in december)
            {
                Console.WriteLine(i);
            }



            var sorting = employees.OrderBy(n => n.Login.TimeOfDay);

            foreach (Employee i in sorting)
            {
                Console.WriteLine(i);
            }


            var earliestemployee = employees.OrderByDescending(n => n.Login.TimeOfDay).LastOrDefault();
            Console.WriteLine(earliestemployee);




            var workedemployees = employees.Where(n => n.Logout.Hour - n.Login.Hour > 8).ToList();

            foreach (var i in workedemployees)
            {
                Console.WriteLine(i);
            }



            var longworkedemployee = employees.OrderBy(n => n.Logout.Hour - n.Login.Hour).LastOrDefault();

            Console.WriteLine(longworkedemployee);



            var loggedoutemployee = employees.Where(n => n.Logout.TimeOfDay > new TimeSpan(18, 0, 0));

            foreach (Employee i in loggedoutemployee)
            {
                Console.WriteLine(i);
            }



            var oldestemployee = employees.OrderBy(n => n.Birthdate)
                .FirstOrDefault();

            Console.WriteLine(oldestemployee);




            var todaybirthday=employees.Where(n => n.Birthdate.Month==DateTime.Now.Month && n.Birthdate.Day==DateTime.Now.Day).ToList();    

            foreach(Employee i in todaybirthday)
            {
                Console.WriteLine(i);
            }

            bool employeeworkedmorthan7 = employees.All(n => n.Logout.Hour - n.Login.Hour > 8);
            Console.WriteLine(employeeworkedmorthan7);



            var groupedByAge = employees.GroupBy(n =>
            {
                int age = DateTime.Today.Year - n.Birthdate.Year;
                if (n.Birthdate > DateTime.Today.AddYears(-age)) age--;
                return age;
            });

            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var emp in group)
                {
                    Console.WriteLine($" - {emp.Name}");
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Basics.AdvanceC_.RegexProblems
{
    internal class Password
    {
        public static void Main(string[] args)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";
            Console.WriteLine("enter the password: ");
            string password = Console.ReadLine();
            if (Regex.IsMatch(pattern,password))
            {
                Console.WriteLine("valid password");
                 
            } else
            {
                Console.WriteLine("invalid password");
            }
        }
    }
}

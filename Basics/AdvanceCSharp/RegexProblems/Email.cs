using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Basics.AdvanceC_.RegexProblems

{
    internal class Email
    {
        public static void Main(string[] args)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Console.WriteLine("enter the email: ");
            string email = Console.ReadLine();

            if (Regex.IsMatch(email,pattern))
            {
                Console.WriteLine("valid email");

            } else
            {
                Console.WriteLine("invalid email");
            }


        }
    }
}

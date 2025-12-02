using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Basics.AdvanceC_.RegexProblems
{
    internal class PhoneNumber
    {
        public static void Main(string [] args)
        {
            string pattern = @"^[6-9]\d{9}$";
            string phonenumber = "8328248056";
            if (Regex.IsMatch(pattern,phonenumber))
            {
                Console.WriteLine("valid phonenumber");  
            } else
            {
                Console.WriteLine("invalid phonenumber");
            }
        }
    }
}

using System;
namespace Strings.stringproblems
{
    internal class PalindromeString
    {
        public static void Main(string[] args)
        {
            string s = "radar";
            string rev = "";
            for (int i=s.Length-1;i>=0;i--)
            {
                rev += s[i];
            }
            if (s.Equals(rev))
            {
                Console.WriteLine("Palindrome String");
            } else
            {
                Console.WriteLine("Not a Palindrome String");
            }
        }
    }
}

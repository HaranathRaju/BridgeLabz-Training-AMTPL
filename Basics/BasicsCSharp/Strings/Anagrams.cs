using System;
namespace Strings.stringproblems
{
    internal class Anagrams
    {
        public static void Main(string[] args)
        {
            string s1 = "Listen";
            string s2 = "silent";
            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            string sorteds1 = new string(arr1);
            string sorteds2 = new string(arr2);
            if (sorteds1 == sorteds2)
            {
                Console.WriteLine("Anagrams");
            }
            else
            {
                Console.WriteLine("Not Anagrams");
            }
        }
    }
}



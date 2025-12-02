using System;
namespace Strings.stringproblems
{
    internal class VowelsCount
    {
        public static void Main(string[] args)
        {
            string s = "hyderabad";
            string vowels = "aeiouAEIOU";
            int vowelcount = 0;
            int consonantcount = 0;
            for (int i=0;i<s.Length;i++)
            {
                if (vowels.Contains(s[i])) {
                    vowelcount++;
                } else
                {
                    consonantcount++;
                }
            }
            Console.WriteLine("Vowels: " + vowelcount);
            Console.WriteLine("Consonants: " + consonantcount);

        }
    }
}

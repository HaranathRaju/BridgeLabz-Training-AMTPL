using System;
namespace Strings.stringproblems
{
    internal class StringCompression
    {
        public static void Main(string[] args)
        {
            string s = "aaaabbbbbccaa";
            string result = "";
            int count = 1;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    count++;
                }
                else
                {
                    result += s[i];
                    result += count.ToString();
                    count = 1;
                }
            }
            result += s[s.Length - 1] + count.ToString();
            Console.WriteLine(result);
        }
    }
}

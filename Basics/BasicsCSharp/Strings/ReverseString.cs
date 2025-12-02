using System;
using System.Text;
namespace Strings.stringproblems
{
    internal class ReverseString
    {
        public static void Main(string[] args)
        {
            string s = "haranath";
            StringBuilder sb = new StringBuilder();
            for(int i=s.Length-1;i>=0;i--)
            {
                sb.Append(s[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

using System;
namespace Strings.stringproblems
{
    internal class StringRotation
    { 
        public static void Main(string[] args)
        {
            string s="waterbottle";
            string result = "";
            int pos = 3;
            for (int i=pos;i<s.Length;i++)
            {
                result += s[i];
            }

            for (int i=0;i<pos;i++)
            {
                result += s[i];
            }
            Console.WriteLine("rotated String: " + result);
        }
    }
}

using System;


namespace Strings.stringproblems
{
    internal class NonRepeatedCharacter
    {
        public static void Main(string[] args)
        {
            string s = "haranath";

            for (int i=0;i<s.Length;i++)
            {
                int count = 1;
                for (int j=i+1;j<s.Length;j++)
                {
                    if (s[i] == s[j])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;

                    }
                }
                if (count==1)
                {
                    Console.WriteLine("First Non-Repeated Character: " + s[i]);
                    break;
                }
            }
        }
    }
}

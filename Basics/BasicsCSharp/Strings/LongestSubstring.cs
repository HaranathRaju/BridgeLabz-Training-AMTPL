using System;
using System.Collections.Generic;
namespace Strings.stringproblems
{
    internal class LongestSubstring
    {
        public static void Main(string[] args)
        {
            string s = "geekforgeeks";
            int maxlen = 0;
            int left = 0;
            int startindex = 0;

            HashSet<char> set=new HashSet<char>();

            for (int i =0;i<s.Length;i++)
            {
                if (!set.Contains(s[i]))
                {
                    set.Add(s[i]);
                }
                else
                {
                    while (s[left] != s[i])
                    {
                        set.Remove(s[left]);
                        left++;
                    }
                    left++;
                }
                if (set.Count > maxlen)
                {
                    maxlen = set.Count;
                    startindex = left;
                }

            }
            Console.WriteLine("Longest Substring is: " + s.Substring(startindex, maxlen));
        }
    }
}

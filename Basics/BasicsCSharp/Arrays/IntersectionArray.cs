using System;
using System.Collections.Generic;
namespace Arrays.problems
{
    internal class IntersectionArray
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 2,2,1};
            int[] arr2 = { 2, 2};
            List<int> result = new List<int>();
            Dictionary<int, int> d = new Dictionary<int, int>();

            foreach(int i in arr1)
            {
                if (d.ContainsKey(i))
                {
                    d[i]++;
                } else
                {
                    d[i] = 1;
                }
            }
            foreach(int j in arr2)
            {
                if (d.ContainsKey(j) && d[j]>0)
                {
                    result.Add(j);
                    d[j]--;
                   
                }
            }
            foreach(int k in result)
            {
                Console.WriteLine(k);
            }
        }
    }
}

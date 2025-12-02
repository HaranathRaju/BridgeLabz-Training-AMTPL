using System;
using System.Collections.Generic;
namespace Arrays.problems
{
    internal class ZeroesToEnd
    {
        public static void Main(string[] args)
        {
            int[] arr = { 0, 1, 0, 3, 12 };
            int[] result = new int[arr.Length];
            int pos = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i]!=0)
                {
                    result[pos] = arr[i];
                    pos++;
                }
            }
            for (int i=0;i<arr.Length;i++)
            { 
                if (arr[i]==0)
                {
                    result[pos] = arr[i];
                    pos++;
                }
            }
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}

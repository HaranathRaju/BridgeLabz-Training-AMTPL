using System;
using System.Collections.Generic;
namespace Arrays.problems
{
    internal class ArrayTargetSum
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 4, 3, 5, 6 };
            int target = 7;
            List<List<int>> list=new List<List<int>>();

            for (int i=0;i<arr.Length;i++)
            {
                for (int j=i+1;j<arr.Length;j++)
                {
                    if (arr[i]+arr[j]==target)
                    {
                        list.Add(new List<int> { arr[i], arr[j] });
                    }
                }
            }
            foreach(var i in list)
            {
                Console.Write("["+string.Join(",", i)+"]");
            }
        }
    }
}

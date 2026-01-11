using System;

namespace DataStructures.dsa
{
    internal class LinearSearch
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int target = 5;
            bool found = false;

            for (int i=0;i<arr.Length;i++) {
                if (arr[i]==target)
                {
                    Console.WriteLine("element found at index : " + i);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("element not found");
            }

        }
    }
}

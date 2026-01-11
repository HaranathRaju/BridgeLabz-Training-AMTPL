using System;

namespace DataStructures.dsa
{
    internal class BinarySearch
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int target = 5;
            int low = 0;
            int high = arr.Length - 1;
            bool found = false;

            while (low<=high)
            {
                int mid=(low+high)/ 2;
                if (arr[mid]==target)
                {
                    Console.WriteLine("element found at index : " + mid);
                    found = true;
                    break;
                } else if (arr[mid]<target)
                {
                    low = mid + 1;
                } else if (arr[mid]>target)
                {
                    high = mid - 1;
                }
            }
            if (!found)
            {
                Console.WriteLine("element not found");
            }
        }
    }
}

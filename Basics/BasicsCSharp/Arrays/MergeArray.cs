using System;

namespace Arrays.problems
{
    internal class MergeArray
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 4, 5 };
            int[] arr2 = { 1, 2, 6, 7, 8 };

            int[] arr = new int[arr1.Length + arr2.Length];

            Array.Copy(arr1, 0, arr, 0, arr1.Length);

            Array.Copy(arr2, 0, arr, arr1.Length, arr2.Length);
            Array.Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}

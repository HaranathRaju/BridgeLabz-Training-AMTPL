using System;
namespace Arrays.problems
{
    internal class RotateArray
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] result = new int[arr.Length];
            int pos = 0;
            int k = 2;
            for (int i=k;i<arr.Length;i++) {
                result[pos] = arr[i];
                pos++;
            }
            for (int i=0;i<k;i++) {
                result[pos] = arr[i];
                pos++;
            }
            foreach(int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}

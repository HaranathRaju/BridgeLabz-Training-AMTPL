using System;


namespace Arrays.problems
{
    internal class MissingNumber
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 6 };
            int arrsum = 0;
            int sum = 0;
            int n = arr.Length + 1;
            int missingnumber = 0;
            for (int i=0;i<arr.Length;i++)
            {
                arrsum += arr[i];
            }
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            missingnumber = sum - arrsum;
            Console.WriteLine("Missing number is: " + missingnumber);
        }
    }
}

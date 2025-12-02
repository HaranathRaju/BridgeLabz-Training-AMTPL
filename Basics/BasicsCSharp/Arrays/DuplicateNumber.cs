using System;
namespace Arrays.problems
{
    internal class DuplicateNumber
    {
        public static void Main(string[] args)
        {
            int[] arr = {2,3,4,1,2};
            int duplicate = arr[0];
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j=i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicate = arr[i];
                        Console.WriteLine("Duplicate number is: " + duplicate);
                    }
                }
            }
        }
    }
}

using System;
namespace Arrays.problems
{
    internal class MajorityElement
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 2, 2, 2, 2, 3 };
            int majorityelement = arr[0];
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > max)
                {
                    max = count;
                    majorityelement = arr[i];
                }
            }
            Console.WriteLine(majorityelement);
        }
    }
}

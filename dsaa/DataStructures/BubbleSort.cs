using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.dsa
{
    internal class BubbleSort
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 5, 4, 3, 2 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("[" + string.Join(",", arr) + "]");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.dsa
{
    internal class SelectionSort
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 5, 4 };
            for (int i=0;i<arr.Length;i++)
            {
                int min = i;
                for (int j=i+1;j<arr.Length;j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            Console.WriteLine("[" + string.Join(",", arr) + "]");
        }
    }
}

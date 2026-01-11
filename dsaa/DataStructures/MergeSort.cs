using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.DataStructures
{
   
    public class Program
    {
        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(arr, left, mid);

           
                MergeSort(arr, mid + 1, right);


                Merge(arr, left, mid, right);
            }
        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArr[i] = arr[left + i];

            for (int i = 0; i < n2; i++)
                rightArr[i] = arr[mid + 1 + i];

            int iIndex = 0, jIndex = 0;
            int k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArr[iIndex] <= rightArr[jIndex])
                    arr[k++] = leftArr[iIndex++];
                else
                    arr[k++] = rightArr[jIndex++];
            }


            while (iIndex < n1)
                arr[k++] = leftArr[iIndex++];

            while (jIndex < n2)
                arr[k++] = rightArr[jIndex++];
        }

        public static void Main(string[] args)
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10 };

            Console.WriteLine("Before sorting:");
            foreach (var x in arr) Console.Write(x + " ");

            MergeSort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nAfter sorting:");
            foreach (var x in arr) Console.Write(x + " ");
        }
    }
}

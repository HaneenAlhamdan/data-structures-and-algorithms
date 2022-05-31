using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.QuickSort
{
    public class Quick_Sort
    {
        public void Quicksort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);
                Quicksort(arr, left, position - 1);
                Quicksort(arr, position + 1, right);
            }
        }
        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;
            for (int i = left; i <= right - 1; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;
        }
        
        public void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
        
        public int[] PrintArray(int[] Array)
        {
            int n = Array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(Array[i] + " ");
            Console.Write("\n");
            return Array;
        }
    }
}

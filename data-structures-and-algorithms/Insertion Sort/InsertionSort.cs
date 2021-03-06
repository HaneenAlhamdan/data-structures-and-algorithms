using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.Insertion_Sort
{
    public class InsertionSort
    {
        public int[] Insertion_Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; ++i)
            {
                int temp = arr[i];
                int j = i - 1;

                
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
            if (arr.Length == 0)
            {
                throw new Exception("Array is empty");
            }
            return arr;
        }
        public int[] PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
            return arr;
        }

    }
}

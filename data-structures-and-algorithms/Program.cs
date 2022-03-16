using System;

namespace data_structures_and_algorithms
{
    class Program
    {
       
    static void originalArray(int[] array)
    {
            Console.WriteLine("Original Array: ");
            foreach (int arr in array)
        {
            Console.WriteLine(arr);
        }
    }

    static void reverseArray(int[] array)
    {
            Console.WriteLine("Reversed Array: ");

            for (int i = 0; i < array.Length/2 ; i++)

            for (int i = 0; i < array.Length /2; i++)

        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
             //   Console.WriteLine(array[i]);
            }
            Console.WriteLine(array);
        }

        static void insertShiftArray(int[] array) 
        { 
        
        }

    static void Main(string[] args)
    {
            int[] arr = new int[] { 89, 2354, 3546, 23, 10, -923, 823, -12 };
            originalArray(arr);
          //  reverseArray(arr);
       
    }
}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms
{

    public static int Search(int[] arr, int searchKey)
    {
        int min = 0;
        int max = arr.Length - 1;
        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (searchKey == arr[mid])
            {
                return mid;
            }
            else if (searchKey > arr[mid])
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }

        return -1;
    }

}


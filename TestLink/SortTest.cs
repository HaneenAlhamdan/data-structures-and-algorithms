using data_structures_and_algorithms.Merge_Sort;
using data_structures_and_algorithms.QuickSort;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestLink
{
    public class SortTest
    {
        //[Fact]
        //public void Test1()
        //{
        //    int[] array = new int[] { };
        //    MergeSort sort = new MergeSort();
        //    Exception ex = Assert.Throws<Exception>(() => sort.Mergesort(array));
        //    Assert.Equal("Array is empty", ex.Message);

        //}
        //[Fact]
        //public void Test2()
        //{
        //    int[] array = { 12, 11, 13, 5, 6 };
        //    int[] result = { 5, 6, 11, 12, 13 };

        //    MergeSort sort = new MergeSort();
        //    sort.Mergesort(array);
        //    Assert.Equal(result, sort.PrintArray(array));

        //}
        //[Fact]
        //public void Test3()
        //{
        //    int[] array = { 20, 18, 12, 8, 5, -2 };
        //    int[] result = { -2, 5, 8, 12, 18, 20 };

        //    MergeSort sort = new MergeSort();
        //    sort.Mergesort(array);
        //    Assert.Equal(result, sort.PrintArray(array));

        //}
        //[Fact]
        //public void Test4()
        //{
        //    int[] array = { 5, 12, 7, 5, 5, 7 };
        //    int[] result = { 5, 5, 5, 7, 7, 12 };

        //    MergeSort sort = new MergeSort();
        //    sort.Mergesort(array);
        //    Assert.Equal(result, sort.PrintArray(array));

        //}
        //[Fact]
        //public void Test5()
        //{
        //    int[] array = { 2, 3, 5, 7, 13, 11 };
        //    int[] result = { 2, 3, 5, 7, 11, 13 };

        //    MergeSort sort = new MergeSort();
        //    sort.Mergesort(array);
        //    Assert.Equal(result, sort.PrintArray(array));

        //}
            /////////////////////////////////////////////////////////////////////

            [Fact]
            public void Quick_Sort1()
            {
                int[] array = { 0, 0, 0, 0, 0 };
                int[] result = { 0, 0, 0, 0, 0 };

            Quick_Sort sort = new Quick_Sort();
                sort.Quicksort(array, 0, array.Length - 1);
                Assert.Equal(result, sort.PrintArray(array));

            }
            [Fact]
            public void Quick_Sort2()
            {
                int[] array = { 12, 11, 13, 5, 6 };
                int[] result = { 5, 6, 11, 12, 13 };

            Quick_Sort sort = new Quick_Sort();
                sort.Quicksort(array, 0, array.Length - 1);
                Assert.Equal(result, sort.PrintArray(array));

            }
            [Fact]
            public void Quick_Sort3()
            {
                int[] array = { 20, 18, 12, 8, 5, -2 };
                int[] result = { -2, 5, 8, 12, 18, 20 };

            Quick_Sort sort = new Quick_Sort();
                sort.Quicksort(array, 0, array.Length - 1);
                Assert.Equal(result, sort.PrintArray(array));

            }
            [Fact]
            public void Quick_Sort4()
            {
                int[] array = { 5, 12, 7, 5, 5, 7 };
                int[] result = { 5, 5, 5, 7, 7, 12 };

            Quick_Sort sort = new Quick_Sort();
                sort.Quicksort(array, 0, array.Length - 1);

            }
            [Fact]
            public void Quick_Sort5()
            {
                int[] array = { 2, 3, 5, 7, 13, 11 };
                int[] result = { 2, 3, 5, 7, 11, 13 };

            Quick_Sort sort = new Quick_Sort();
                sort.Quicksort(array, 0, array.Length - 1);
                Assert.Equal(result, sort.PrintArray(array));

            }

        
    }
}

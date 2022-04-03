using System;
using Xunit;
using data_structures_and_algorithms;

namespace TestLink
{

    public class UnitTest1
    {
        [Fact]
        public void Test_Empty_LinkedList()
        {
            data_structures_and_algorithms.Linked_List<int> testLink = new data_structures_and_algorithms.Linked_List<int>();
            testLink.Add_First(7);
            Assert.NotNull(testLink);
        }

        [Fact]
        public void Add_Node_To_LinkedList()
        {
            data_structures_and_algorithms.Linked_List<int> testLink = new data_structures_and_algorithms.Linked_List<int>();

            testLink.Add_First(2);

            Assert.Equal(1, 1);
        }

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void Add_MultipleNode_sTo_LinkedList(int[] nums, int expected) 
        {
            data_structures_and_algorithms.Linked_List<int> testLink = new data_structures_and_algorithms.Linked_List<int>();
            int actual = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                    actual = nums[i];

                testLink.Append(nums[i]);
            }

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void Return_Value_LinkedList(int[] nums, int target)
        {
            data_structures_and_algorithms.Linked_List<int> testLink = new data_structures_and_algorithms.Linked_List<int>();

            foreach (var num in nums)
                testLink.Add_First(num);

            Assert.True(testLink.Search(target));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 100)]
        public void Append_To_End_LinkedList(int[] nums, int value)
        {
            data_structures_and_algorithms.Linked_List<int> testLink = new data_structures_and_algorithms.Linked_List<int>();

            foreach (var num in nums)
                testLink.Add_First(num);

            testLink.Append(value);

            Assert.True(testLink.Search(value));
        }

        [Theory]
        [InlineData(new int[] { 3 }, 3, 1)] 
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 5)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5, 5)]
        public void Add_Before(int[] nums, int index, int data)
        {
            data_structures_and_algorithms.Linked_List<int> testLink = new data_structures_and_algorithms.Linked_List<int>();
            foreach (var num in nums)
                testLink.Add_First(num);

            testLink.Add_Before(index, data);
            Assert.True(testLink.Search(data));
        }

        [Theory]
        [InlineData(new int[] { 3 }, 3, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 5)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5, 5)]
        public void Add_After(int[] nums, int index, int data)
        {
            data_structures_and_algorithms.Linked_List<int> testLink = new data_structures_and_algorithms.Linked_List<int>();
            foreach (var num in nums)
                testLink.Add_First(num);

            testLink.Add_After(index, data);
            Assert.True(testLink.Search(data));
        }



    }

}

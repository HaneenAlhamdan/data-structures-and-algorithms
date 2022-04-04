using System;
using Xunit;
using data_structures_and_algorithms;

namespace TestLink
{

    public class UnitTest1        
    {
        [Fact]
        public void CreateEmptyLinkedListTest()
        {
            Linked_List testLink = new Linked_List();
            Assert.Null(testLink.head);
        }
        //[Fact]
        //public void InsertTest()
        //{
        //    Linked_List testLink = new Linked_List();
        //    testLink.Insert(10);
        //    Node temp = testLink.head;
        //    Assert.NotNull(testLink.head);
        //    Assert.Equal(10, temp.data);
        //}
        //[Fact]
        //public void HeadTest()
        //{
        //    Linked_List testLink = new Linked_List();
        //    testLink.Insert(10);
        //    testLink.Insert(20);
        //    Node temp = testLink.head;
        //    Assert.Equal(20, temp.data);
        //}
        //[Fact]
        //public void InsertMultipleNodesTest()
        //{
        //    Linked_List testLink = new Linked_List();
        //    testLink.Insert(9);
        //    testLink.Insert(34);
        //    testLink.Insert(56);
        //    testLink.Insert(95);
        //    Node temp = testLink.head;
        //    Assert.Equal(95, temp.data);
        //}
        ////[Fact]
        ////public void IncludesFoundTest()
        ////{
        ////    Linked_List testLink = new Linked_List();
        ////    testLink.Insert(9);
        ////    testLink.Insert(34);
        ////    Assert.True(testLink.Includes(34));
        ////}
        ////[Fact]
        ////public void IncludesNotFoundTest()
        ////{
        ////    Linked_List testLink = new Linked_List();
        ////    testLink.Insert(9);
        ////    testLink.Insert(34);
        ////    Assert.False(testLink.Includes(100));
        ////}
        //[Fact]
        //public void ValesTest()
        //{
        //    Linked_List testLink = new Linked_List();
        //    testLink.Insert(10);
        //    testLink.Insert(15);
        //    testLink.Insert(18);
        //    testLink.Insert(20);
        //    Assert.Equal("[20] -> [18] -> [15] -> [10] -> NULL", testLink.To_String());
        //}

        [Fact]
        public void Append_Link_Test()
        {
            Linked_List testLink = new Linked_List();
            testLink.Append(777);
            testLink.Append(100);
            testLink.Append(15);
            testLink.Append(20);
            Assert.Equal("[777] -> [100] -> [15] -> [20] -> NULL", testLink.To_String());
        }

        [Fact]
        public void Insert_Before_Middle_Test()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(1);
            testLink.Add_After(1, 2);
            testLink.Add_After(2, 3);
            testLink.Add_Before(2, 10);
            Assert.Equal("[1] -> [10] -> [2] -> [3] -> NULL", testLink.To_String());
        }

        [Fact]
        public void InsertBeforeFirstTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(777);
            testLink.Add_Before(777, 100);
            Assert.Equal("[100] -> [777] -> NULL", testLink.To_String());
        }

        [Fact]
        public void InsertAfterMiddle()
        {
            Linked_List testLink = new Linked_List();
            testLink.Append(1);
            testLink.Append(2);
            testLink.Append(3);
            testLink.Add_After(2, 99);
            Assert.Equal("[1] -> [2] -> [99] -> [3] -> NULL", testLink.To_String());
        }

        [Fact]
        public void InsertAfterLast()
        {
            Linked_List testLink = new Linked_List();
            testLink.Append(1);
            testLink.Append(2);
            testLink.Append(3);
            testLink.Add_After(3, 99);
            Assert.Equal("[1] -> [2] -> [3] -> [99] -> NULL", testLink.To_String());
        }

        [Fact]
        public void GreaterThanLengthTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Append(1);
            testLink.Append(2);
            testLink.Append(3);
            Assert.Null(testLink.KthForm(6));
        }

        [Fact]
        public void LengthEqualsKTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Append(1);
            testLink.Append(2);
            Assert.Equal(1, testLink.KthForm(1));
        }

        [Fact]
        public void NegativeKValue()
        {
            Linked_List testLink = new Linked_List();
            testLink.Append(1);
            testLink.Append(2);
            testLink.Append(3);
            Assert.Null(testLink.KthForm(-3));
        }

        [Fact]
        public void SizeOfOneTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Append(1);
            Assert.Equal(1, testLink.KthForm(0));
        }

        [Fact]
        public void MiddleKTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Append(1);
            testLink.Append(2);
            testLink.Append(3);
            testLink.Append(4);
            testLink.Append(5);
            Assert.Equal(3, testLink.KthForm(2));
        }

    }

}

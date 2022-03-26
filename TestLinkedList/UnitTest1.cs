using System;
using Xunit;
using data_structures_and_algorithms;


namespace TestLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void CreateEmptyLinkedListTest()
        {
            Linked_List testLink = new Linked_List();
            Assert.Null(testLink.head);
        }
        [Fact]
        public void InsertTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(8);
            Node temp = testLink.head;
            Assert.NotNull(testLink.head);
            Assert.Equal(8, temp.data);
        }
        [Fact]
        public void HeadTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(10);
            testLink.Insert(20);
            Node temp = testLink.head;
            Assert.Equal(20, temp.data);
        }
        [Fact]
        public void InsertMultipleNodesTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(9);
            testLink.Insert(34);
            testLink.Insert(56);
            testLink.Insert(95);
            Node temp = testLink.head;
            Assert.Equal(95, temp.data);
        }
        [Fact]
        public void IncludeFoundTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(9);
            testLink.Insert(34);
            Assert.True(testLink.Include(34));
        }
        [Fact]
        public void IncludeNotFoundTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(9);
            testLink.Insert(34);
            Assert.False(testLink.Include(100));
        }
        [Fact]
        public void ValesTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(10);
            testLink.Insert(15);
            testLink.Insert(18);
            testLink.Insert(20);
            Assert.Equal("[20] -> [18] -> [15] -> [10] -> NULL", testLink.To_String());
        }
    }
}

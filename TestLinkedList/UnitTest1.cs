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
            testLink.Insert(8);
            testLink.Insert(21);
            Node temp = testLink.head;
            Assert.Equal(21, temp.data);
        }
        [Fact]
        public void InsertMultipleNodesTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(4);
            testLink.Insert(42);
            testLink.Insert(61);
            testLink.Insert(77);
            Node temp = testLink.head;
            Assert.Equal(77, temp.data);
        }
        [Fact]
        public void IncludeFoundTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(4);
            testLink.Insert(42);
            Assert.True(testLink.Include(42));
        }
        [Fact]
        public void IncludeNotFoundTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(4);
            testLink.Insert(42);
            Assert.False(testLink.Include(125));
        }
        [Fact]
        public void ValesTest()
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(8);
            testLink.Insert(12);
            testLink.Insert(7);
            testLink.Insert(21);
            Assert.Equal("[21] -> [17] -> [12] -> [8] -> NULL", testLink.To_String());
        }
    }
}

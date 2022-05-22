//using System;
//using Xunit;
////using data_structures_and_algorithms.Node;
////using data_structures_and_algorithms.Stacks_and_Queues;
//using data_structures_and_algorithms.stack_queue_animal_shelter;
//using data_structures_and_algorithms.stack_queue_brackets;
//using data_structures_and_algorithms.Trees;

//namespace TestLink
//{

//    public class UnitTest1
//    {
//        //    [Fact]
//        //    public void CreateEmptyLinkedListTest()
//        //    {
//        //        Linked_List testLink = new Linked_List();
//        //        Assert.Null(testLink.head);
//        //    }
//        //    [Fact]
//        //    public void InsertTest()
//        //    {
//        //        Linked_List testLink = new Linked_List();
//        //        testLink.Insert(10);
//        //        Node temp = testLink.head;
//        //        Assert.NotNull(testLink.head);
//        //        Assert.Equal(10, temp.data);
//        //    }
//        //    [Fact]
//        //    public void HeadTest()
//        //    {
//        //        Linked_List testLink = new Linked_List();
//        //        testLink.Insert(10);
//        //        testLink.Insert(20);
//        //        Node temp = testLink.head;
//        //        Assert.Equal(20, temp.data);
//        //    }
//        //    [Fact]
//        //    public void InsertMultipleNodesTest()
//        //    {
//        //        Linked_List testLink = new Linked_List();
//        //        testLink.Insert(9);
//        //        testLink.Insert(34);
//        //        testLink.Insert(56);
//        //    testLink.Insert(95);
//        //    Node temp = testLink.head;
//        //    Assert.Equal(95, temp.data);
//        //}
//        //[Fact]
//        //public void IncludesFoundTest()
//        //{
//        //    Linked_List testLink = new Linked_List();
//        //    testLink.Insert(9);
//        //    testLink.Insert(34);
//        //    Assert.True(testLink.Includes(34));
//        //}
//        //[Fact]
//        //public void IncludesNotFoundTest()
//        //{
//        //    Linked_List testLink = new Linked_List();
//        //    testLink.Insert(9);
//        //    testLink.Insert(34);
//        //    Assert.False(testLink.Includes(100));
//        //}
//        //[Fact]
//        //public void ValesTest()
//        //{
//        //    Linked_List testLink = new Linked_List();
//        //    testLink.Insert(10);
//        //    testLink.Insert(15);
//        //    testLink.Insert(18);
//        //    testLink.Insert(20);
//        //    Assert.Equal("[20] -> [18] -> [15] -> [10] -> NULL", testLink.To_String());
//        //}

//        //[Fact]
//        //public void Append_Link_Test()
//        //{
//        //    Linked_List testLink = new Linked_List();
//        //    testLink.Append(777);
//        //    testLink.Append(100);
//        //    testLink.Append(15);
//        //    testLink.Append(20);
//        //    Assert.Equal("[777] -> [100] -> [15] -> [20] -> NULL", testLink.To_String());
//        //}

//        //[Fact]
//        //public void Insert_Before_Middle_Test()
//        //{
//        //    Linked_List testLink = new Linked_List();
//        //    testLink.Insert(1);
//        //    testLink.Add_After(1, 2);
//        //    testLink.Add_After(2, 3);
//        //    testLink.Add_Before(2, 10);
//        //    Assert.Equal("[1] -> [10] -> [2] -> [3] -> NULL", testLink.To_String());
//        //}

//        //[Fact]
//        //public void InsertBeforeFirstTest()
//        //{
//        //    Linked_List testLink = new Linked_List();
//        //    testLink.Insert(777);
//        //    testLink.Add_Before(777, 100);
//        //    Assert.Equal("[100] -> [777] -> NULL", testLink.To_String());
//        //}

//        //[Fact]
//        //public void InsertAfterMiddle()
//        //{
//        //    Linked_List testLink = new Linked_List();
//        //    testLink.Append(1);
//        //    testLink.Append(2);
//        //    testLink.Append(3);
//        //    testLink.Add_After(2, 99);
//        //    Assert.Equal("[1] -> [2] -> [99] -> [3] -> NULL", testLink.To_String());
//        //}

//        //[Fact]
//        //public void InsertAfterLast()
//        //{
//        //    Linked_List testLink = new Linked_List();
//        //    testLink.Append(1);
//        //    testLink.Append(2);
//        //    testLink.Append(3);
//        //    testLink.Add_After(3, 99);
//        //    Assert.Equal("[1] -> [2] -> [3] -> [99] -> NULL", testLink.To_String());
//        //}

//        //[Fact]
//        //public void GreaterThanLengthTest()
//        //{
//        //    Linked_List testLink = new Linked_List();
//        //    testLink.Append(1);
//        //    testLink.Append(2);
//        //    testLink.Append(3);
//        //    Assert.Null(testLink.KthForm(6));
//        //}



//        //[Fact]
//        //public void NegativeKValue()
//        //{
//        //    Linked_List testLink = new Linked_List();
//        //    testLink.Append(1);
//        //    testLink.Append(2);
//        //    testLink.Append(3);
//        //    Assert.Null(testLink.KthForm(-3));
//        //}

//        ////[Fact]
//        ////public void SizeOfOneTest()
//        ////{
//        ////    Linked_List testLink = new Linked_List();
//        ////    testLink.Append(5);
//        ////    Assert.Equal(1, testLink.KthForm(0));
//        ////}

//        ////[Fact]
//        ////public void LengthEqualsKTest()
//        ////{
//        ////    Linked_List testLink = new Linked_List();
//        ////    testLink.Append(1);
//        ////    testLink.Append(2);
//        ////   // testLink.Append(3);
//        ////    Assert.Equal(1, testLink.KthForm(1));
//        ////}
//        ////[Fact]
//        ////public void MiddleKTest()
//        ////{
//        ////    Linked_List testLink = new Linked_List();
//        ////    testLink.Append(1);
//        ////    testLink.Append(2);
//        ////    testLink.Append(3);
//        ////    testLink.Append(4);
//        ////    testLink.Append(5);
//        ////    Assert.Equal(3, testLink.KthForm(2));
//        ////}

//        //[Fact]
//        //public void NullListsTest()
//        //{
//        //    Linked_List list1 = new Linked_List();
//        //    Linked_List list2 = new Linked_List();
//        //    Assert.Null(Linked_List.list_zip(list1, list2).head);
//        //}

//        //[Fact]
//        //public void FirstListIsNullTest()
//        //{
//        //    Linked_List list1 = new Linked_List();
//        //    Linked_List list2 = new Linked_List();
//        //    list2.Append(10);
//        //    list2.Append(20);
//        //    list2.Append(30);
//        //    Assert.Equal("[10] -> [20] -> [30] -> NULL", Linked_List.list_zip(list1, list2).To_String());
//        //}

//        //[Fact]
//        //public void SecondListIsNullTest()
//        //{
//        //    Linked_List list1 = new Linked_List();
//        //    Linked_List list2 = new Linked_List();
//        //    list1.Append(10);
//        //    list1.Append(20);
//        //    list1.Append(30);
//        //    Assert.Equal("[10] -> [20] -> [30] -> NULL", Linked_List.list_zip(list1, list2).To_String());
//        //}

//        //[Fact]
//        //public void FirstListLonger()
//        //{
//        //    Linked_List list1 = new Linked_List();
//        //    Linked_List list2 = new Linked_List();
//        //    list1.Append(10);
//        //    list1.Append(20);
//        //    list1.Append(30);
//        //    list1.Append(40);
//        //    list2.Append(50);
//        //    list2.Append(60);
//        //    Assert.Equal("[10] -> [50] -> [20] -> [60] -> [30] -> [40] -> NULL", Linked_List.list_zip(list1, list2).To_String());
//        //}

//        //[Fact]
//        //public void SecondListLonger()
//        //{
//        //    Linked_List list1 = new Linked_List();
//        //    Linked_List list2 = new Linked_List();
//        //    list1.Append(1);
//        //    list1.Append(2);
//        //    list2.Append(3);
//        //    list2.Append(4);
//        //    list2.Append(5);
//        //    list2.Append(6);
//        //    Assert.Equal("[1] -> [3] -> [2] -> [4] -> [5] -> [6] -> NULL", Linked_List.list_zip(list1, list2).To_String());
//        //}

//        //[Fact]
//        //public void StackPushTest()
//        //{
//        //    Stack stack = new Stack();
//        //    stack.Push(10);
//        //    stack.Push(76);
//        //    stack.Push(15);
//        //    Assert.Equal(15, stack.top.data);
//        //}

//        //[Fact]
//        //public void StackPopTest()
//        //{
//        //    Stack stack = new Stack();
//        //    stack.Push(10);
//        //    stack.Push(15);
//        //    Assert.Equal(15, stack.Pop());
//        //}

//        //[Fact]
//        //public void EmptyTheStackTest()
//        //{
//        //    Stack stack = new Stack();
//        //    stack.Push(10);
//        //    stack.Push(15);
//        //    stack.Pop();
//        //    stack.Pop();
//        //    Assert.Null(stack.top);
//        //}

//        //[Fact]
//        //public void StackPeekTest()
//        //{
//        //    Stack stack = new Stack();
//        //    stack.Push(10);
//        //    stack.Push(15);
//        //    Assert.Equal(15, stack.Peek());
//        //}

//        //[Fact]
//        //public void StackIsEmptyTest()
//        //{
//        //    Stack stack = new Stack();
//        //    Assert.True(stack.IsEmpty());
//        //}

//        //[Fact]
//        //public void PopPeekEmptyStack()
//        //{
//        //    Stack stack = new Stack();
//        //    Assert.Null(stack.Pop());
//        //    Assert.Null(stack.Peek());
//        //}

//        //[Fact]
//        //public void InsertIntoQueueTest()
//        //{
//        //    Queue queue = new Queue();
//        //    queue.Enqueue(10);
//        //    queue.Enqueue(15);
//        //    queue.Enqueue(50);
//        //    Assert.Equal(10, queue.front.data);
//        //    Assert.Equal(50, queue.rear.data);
//        //}

//        //[Fact]
//        //public void DeleteFromQueueTest()
//        //{
//        //    Queue queue = new Queue();
//        //    queue.Enqueue(10);
//        //    queue.Enqueue(15);
//        //    Assert.Equal(10, queue.Dequeue());
//        //}

//        //[Fact]
//        //public void PeekQueueTest()
//        //{
//        //    Queue queue = new Queue();
//        //    queue.Enqueue(10);
//        //    queue.Enqueue(15);
//        //    queue.Enqueue(34);
//        //    queue.Enqueue(52);
//        //    Assert.Equal(10, queue.Peek());
//        //}

//        //[Fact]
//        //public void EmptyTheQueueTest()
//        //{
//        //    Queue queue = new Queue();
//        //    queue.Enqueue(10);
//        //    queue.Enqueue(15);
//        //    queue.Dequeue();
//        //    queue.Dequeue();
//        //    Assert.Null(queue.front);
//        //    Assert.Null(queue.rear);
//        //}

//        //[Fact]
//        //public void QueueIsEmptyTest()
//        //{
//        //    Queue queue = new Queue();
//        //    Assert.True(queue.IsEmpty());
//        //}

//        //[Fact]
//        //public void DequeuePeekEmptyQueue()
//        //{
//        //    Queue queue = new Queue();
//        //    Assert.Null(queue.Dequeue());
//        //    Assert.Null(queue.Peek());
//        //}


//        [Fact]
//        public void TestEnqueue()
//        {
//            AnimalShelter animalShelter = new AnimalShelter(1, "Happy Shelter");
//            Cat cat1 = new Cat("Milo", 2);
//            Cat cat2 = new Cat("Suger", 3);
//            animalShelter.Enqueue(cat1);
//            animalShelter.Enqueue(cat2);
//            Assert.Equal(cat1.Name, animalShelter.GetAnimals().Peek().Name);
//        }

//        [Fact]
//        public void TestDequeue()
//        {
//            AnimalShelter animalShelter = new AnimalShelter(1, "Happy Shelter");
//            Cat cat1 = new Cat("Milo", 2);
//            Cat cat2 = new Cat("Suger", 4);
//            Dog dog1 = new Dog("Mouna", 5);
//            animalShelter.Enqueue(cat1);
//            animalShelter.Enqueue(cat2);
//            animalShelter.Enqueue(dog1);
//            Assert.Equal(dog1.Name, animalShelter.Dequeue("dog").Name);
//            Assert.Equal(cat1.Name, animalShelter.Dequeue("cat").Name);
//        }

//        [Fact]
//        public void TestDequeueAnimalNotInShelter()
//        {
//            AnimalShelter animalShelter = new AnimalShelter(1, "Happy Shelter");
//            Cat cat1 = new Cat("Milo", 2);
//            Cat cat2 = new Cat("Suger", 4);
//            Dog dog1 = new Dog("Mouna", 5);
//            animalShelter.Enqueue(cat1);
//            animalShelter.Enqueue(cat2);
//            animalShelter.Enqueue(dog1);
//            Assert.Null(animalShelter.Dequeue("Fish"));
//        }

//        [Fact]
//        public void TestDequeueEmptyShelter()
//        {
//            AnimalShelter animalShelter = new AnimalShelter(1, "Happy Shelter");
//            Assert.Null(animalShelter.Dequeue("dog"));
//        }

        
//        //////////////////////////////////////////////////////////////////////////////////////////////////////// 
        
        
//        [Fact]
//        public void Test_Balanced_Brackets()
//        {
//            Assert.True(stack_queue_brackets.ValidateBrackets("({[]})"));
//            Assert.True(stack_queue_brackets.ValidateBrackets("{}"));
//            Assert.True(stack_queue_brackets.ValidateBrackets("{}(){}"));
//            Assert.True(stack_queue_brackets.ValidateBrackets("()[[Extra Characters]]"));
//            Assert.True(stack_queue_brackets.ValidateBrackets("(){}[[]]"));
//            Assert.True(stack_queue_brackets.ValidateBrackets("{}{Code}[Fellows](())"));
//        }

//        [Fact]
//        public void Test_Not_Balanced_Brackets()
//        {
//            Assert.False(stack_queue_brackets.ValidateBrackets("(]("));
//            Assert.False(stack_queue_brackets.ValidateBrackets("[({}]"));
//            Assert.False(stack_queue_brackets.ValidateBrackets("{(})"));
//            Assert.False(stack_queue_brackets.ValidateBrackets(""));
//        }

//        /////////////////////////////////////////////////////////////////////////////////////////////

//        BinaryTree tree = new BinaryTree();

//        [Fact]
//        public void Instantiate_Empty_Tree()
//        {
//            Assert.Null(tree.Root);
//        }
//        [Fact]
//        public void Instantiate_Empty_Tree_with_Single_Root()
//        {
//            tree.Root = new NodeTree(15);
//            Assert.NotNull(tree.Root);
//        }
//        [Fact]
//        public void Test_Preorder_Traversal()
//        {
//            tree.Root = new NodeTree(1);
//            tree.Root.Left = new NodeTree(2);
//            tree.Root.Right = new NodeTree(3);
//            tree.Root.Left.Left = new NodeTree(4);
//            tree.Root.Left.Right = new NodeTree(5);
//            int[] arr = { 1, 2, 4, 5, 3 };

//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.Write(arr[i] + " ");
//            }
//            Assert.Equal(arr, tree.PreOrder(tree.Root));
//        }
//        [Fact]
//        public void Test_Inorder_Traversal()
//        {
//            tree.Root = new NodeTree(1);
//            tree.Root.Left = new NodeTree(2);
//            tree.Root.Right = new NodeTree(3);
//            tree.Root.Left.Left = new NodeTree(4);
//            tree.Root.Left.Right = new NodeTree(5);
//            int[] arr = { 4, 2, 5, 1, 3 };

//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.Write(arr[i] + " ");
//            }
//            Assert.Equal(arr, tree.InOrder(tree.Root));
//        }
//        [Fact]
//        public void Test_Postorder_Traversal()
//        {
//            tree.Root = new NodeTree(1);
//            tree.Root.Left = new NodeTree(2);
//            tree.Root.Right = new NodeTree(3);
//            tree.Root.Left.Left = new NodeTree(4);
//            tree.Root.Left.Right = new NodeTree(5);
//            int[] arr = { 4, 5, 2, 3, 1 };

//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.Write(arr[i] + " ");
//            }
//            Assert.Equal(arr, tree.PostOrder(tree.Root));
//        }
//        [Fact]
//        public void Test_Binary_Search_Tree()
//        {
//            BinarySearchTree binarySearchTree = new BinarySearchTree();
//            binarySearchTree.Add(10);
//            binarySearchTree.Add(15);
//            binarySearchTree.Add(35);
//            binarySearchTree.Add(26);
//            binarySearchTree.Add(47);
//            int[] arr = { 10, 15, 35, 26, 47 };
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.Write(arr[i] + " ");
//            }
//            Assert.Equal(arr, binarySearchTree.PreOrder(binarySearchTree.Root));
//        }
//        [Fact]
//        public void Test_Binary_Search_Tree_Contains_True()
//        {
//            BinarySearchTree binarySearchTree = new BinarySearchTree();
//            binarySearchTree.Add(10);
//            binarySearchTree.Add(15);
//            binarySearchTree.Add(35);
//            Assert.True(binarySearchTree.Contains(10));
//        }
//        [Fact]
//        public void Test_Binary_Search_Tree_Contains_False()
//        {
//            BinarySearchTree binarySearchTree = new BinarySearchTree();
//            binarySearchTree.Add(10);
//            binarySearchTree.Add(15);
//            binarySearchTree.Add(35);
//            Assert.False(binarySearchTree.Contains(20));
//        }
//        [Fact]
//        public void Test_Add_ToLeft_BST()
//        {
//            BinarySearchTree binarySearchTree = new BinarySearchTree();
//            binarySearchTree.Add(10);
//            binarySearchTree.Add(5);
//            Assert.NotNull(binarySearchTree.Root.Left);
//            Assert.Null(binarySearchTree.Root.Right);
//        }
//        [Fact]
//        public void Test_Add_ToRight_BST()
//        {
//            BinarySearchTree binarySearchTree = new BinarySearchTree();
//            binarySearchTree.Add(10);
//            binarySearchTree.Add(15);
//            Assert.Null(binarySearchTree.Root.Left);
//            Assert.NotNull(binarySearchTree.Root.Right);
//        }

//        /////////////////////////////////////////////////////////////////////////////////////////////
//        ///

//        [Fact]
//        public void Test_Max_Binary_Tree_One()
//        {
//            BinaryTree tree = new BinaryTree();
//            tree.Root = new NodeTree(1);
//            tree.Root.Left = new NodeTree(2);
//            tree.Root.Right = new NodeTree(13);
//            tree.Root.Left.Left = new NodeTree(4);
//            tree.Root.Left.Right = new NodeTree(5);
//            Assert.Equal(13, tree.Maximum());
//        }
//        [Fact]
//        public void Test_Max_Binary_Tree_Two()
//        {
//            BinaryTree tree = new BinaryTree();
//            tree.Root = new NodeTree(1);
//            tree.Root.Left = new NodeTree(2);
//            tree.Root.Right = new NodeTree(13);
//            tree.Root.Left.Left = new NodeTree(4);
//            tree.Root.Left.Right = new NodeTree(5);
//            Assert.NotEqual(5, tree.Maximum());
//        }
//    }
//}


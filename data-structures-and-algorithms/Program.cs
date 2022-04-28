﻿using System;
using data_structures_and_algorithms;
//using data_structures_and_algorithms.Stacks_and_Queues;
//using data_structures_and_algorithms.stack_queue_pseudo;
using data_structures_and_algorithms.stack_queue_animal_shelter;
using data_structures_and_algorithms.stack_queue_brackets;
using System.Collections.Generic;
using System.Collections;
using data_structures_and_algorithms.Trees;


namespace data_structures_and_algorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Linked_List testLink = new Linked_List();
            //  Console.WriteLine("haneen");


            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //   Console.WriteLine(Search.Search(arr, 4));

            //testLink.Append(14);
            //testLink.Insert(28);
            //   Console.WriteLine(testLink.To_String());

            //testLink.Add_After(14, 7);
            //testLink.Add_Before(28, 50);
            //   Console.WriteLine(testLink.To_String());

            //testLink.Add_After(50, 9);
            //testLink.Append(42);
            //   Console.WriteLine(testLink.To_String());

            //testLink.Add_After(123, 1);
            //testLink.DeleteNode(7);
            //Console.WriteLine(testLink.To_String());
            //Console.WriteLine($"\nIs it Include 76?  {testLink.Includes(76)}");
            //Console.WriteLine($"Is it Include 50?  {testLink.Includes(50)}");


            //   Console.WriteLine(testLink.KthForm(0));
            //   Console.WriteLine(testLink.KthForm(4));
            //   Console.WriteLine(testLink.KthForm(2));
            //   Console.WriteLine(testLink.KthForm(23));
            //   Console.WriteLine(testLink.KthForm(-5));




            // Linked_List list1 = new Linked_List();  
            // list1.Append(10);
            //list1.Append(20);
            //list1.Append(30);
            // Linked_List list2 = new Linked_List(); 
            //list2.Append(40);
            //list2.Append(50);
            //list2.Append(60);
            //Console.WriteLine("List One :- " + list1.To_String());
            //Console.WriteLine("List Two :- " + list2.To_String());   
            //Linked_List.list_zip(list1, list2);       
            //Console.WriteLine("Zip two linked lists :- " + list1.To_String());


            // Stack newStack = new Stack();
            // newStack.Peek();
            // newStack.Push(2);
            // newStack.Push(4);
            // Console.WriteLine(newStack.IsEmpty());
            // newStack.Pop();
            // newStack.Peek();
            //// Console.WriteLine(newStack.ToString());

            // Console.WriteLine("\n \n");
            // Queue newQueue = new Queue();
            // newQueue.Peek();
            // newQueue.Enqueue(2);
            // newQueue.Enqueue(4);
            // Console.WriteLine(newQueue.IsEmpty());
            // newQueue.Dequeue();
            // newQueue.Peek();
            // Console.WriteLine(newQueue.ToString());

            //Console.WriteLine("\n \n");

            //stack_queue_pseudo newstack_Queue_Pseudo = new stack_queue_pseudo();
            //newstack_Queue_Pseudo.Enqueue(1);
            //newstack_Queue_Pseudo.Enqueue(2);
            //newstack_Queue_Pseudo.Enqueue(3);
            //Console.WriteLine("Peek is :" + newstack_Queue_Pseudo.Peek());
            //newstack_Queue_Pseudo.Dequeue();
            //Console.WriteLine("Peek after Dequeue is :" + newstack_Queue_Pseudo.Peek());

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            AnimalShelter animalShelter = new AnimalShelter(1, " Happy Shelter");
            Cat cat1 = new Cat("Milo", 2);
            Cat cat2 = new Cat("Suger", 4);
            Dog dog1 = new Dog("Mouna", 5);
            Cat cat3 = new Cat("Lele", 1);
            Dog dog2 = new Dog("Katy", 7);
            animalShelter.Enqueue(cat1);
            animalShelter.Enqueue(cat2);
            animalShelter.Enqueue(dog1);
            animalShelter.Enqueue(cat3);
            animalShelter.Enqueue(dog2);
            Animal animal1 = animalShelter.Dequeue("cat");
            Animal animal2 = animalShelter.Dequeue("dog");
            Animal animal3 = animalShelter.Dequeue("cat");
            Console.WriteLine(animal1.Name);
            Console.WriteLine(animal2.Name);
            Console.WriteLine(animal3.Name);

            Console.WriteLine("\n \n");
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(stack_queue_brackets.stack_queue_brackets.ValidateBrackets("{(})"));


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n \n");
           

            BinaryTree tree = new BinaryTree();
            tree.Root = new NodeTree(1);
            tree.Root.Left = new NodeTree(2);
            tree.Root.Right = new NodeTree(3);
            tree.Root.Left.Left = new NodeTree(4);
            tree.Root.Left.Right = new NodeTree(5);

            Console.WriteLine("\n" + "Pre order: ");
            int[] arr = tree.PreOrder(tree.Root);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            tree.list.Clear();
            Console.WriteLine();

            Console.WriteLine("\n" + "In order: ");
            int[] arr2 = tree.InOrder(tree.Root);

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            tree.list.Clear();
            Console.WriteLine();

            Console.WriteLine("\n"+ "Post order: ");
            int[] arr3 = tree.PostOrder(tree.Root);

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine();


            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(16);
            binarySearchTree.Add(22);
            binarySearchTree.Add(39);
            binarySearchTree.Add(20);
            binarySearchTree.Add(33);

            int[] arr4 = binarySearchTree.PreOrder(binarySearchTree.Root);
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.Write(arr4[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine(binarySearchTree.Contains(0));



            Console.WriteLine();
            Console.WriteLine("The Maximum value in Binary Tree is: " + tree.FindMax());


        }  
    }
}
    


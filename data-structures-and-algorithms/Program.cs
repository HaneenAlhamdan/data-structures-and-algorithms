using System;
using data_structures_and_algorithms;
using data_structures_and_algorithms.Stacks_and_Queues;

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


            Stack newStack = new Stack();
            newStack.Peek();
            newStack.Push(2);
            newStack.Push(4);
            Console.WriteLine(newStack.IsEmpty()); 
            newStack.Pop();
            newStack.Peek(); 

            Console.WriteLine("\n \n");
            Queue newQueue = new Queue();
            newQueue.Peek();
            newQueue.Enqueue(2);
            newQueue.Enqueue(4);
            Console.WriteLine(newQueue.IsEmpty()); 
            newQueue.Dequeue(); 
            newQueue.Peek();

            Console.WriteLine("Haneen");

        }
}
    }


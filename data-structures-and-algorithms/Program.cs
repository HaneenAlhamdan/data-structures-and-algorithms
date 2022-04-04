using System;
using data_structures_and_algorithms;

namespace data_structures_and_algorithms
{
    class Program
    {
       public static void Main(string[] args)
        {
            Linked_List testLink = new Linked_List();
          //  Console.WriteLine("haneen");


         //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
         //   Console.WriteLine(Search.Search(arr, 4));
         
         testLink.Append(14);
         testLink.Insert(28);
            Console.WriteLine(testLink.To_String());

         testLink.Add_After(14, 7);
         testLink.Add_Before(28, 50);
            Console.WriteLine(testLink.To_String());

         testLink.Add_After(50, 9);
         testLink.Append(42);
            Console.WriteLine(testLink.To_String());

         testLink.Add_After(123, 1);
         testLink.DeleteNode(7);
         Console.WriteLine(testLink.To_String());
         Console.WriteLine($"\nIs it Include 76?  {testLink.Includes(76)}");
         Console.WriteLine($"Is it Include 50?  {testLink.Includes(50)}");


            Console.WriteLine(testLink.KthForm(0));
            Console.WriteLine(testLink.KthForm(4));
            Console.WriteLine(testLink.KthForm(2));
            Console.WriteLine(testLink.KthForm(23));
            Console.WriteLine(testLink.KthForm(-5));
           


        }
}
    }


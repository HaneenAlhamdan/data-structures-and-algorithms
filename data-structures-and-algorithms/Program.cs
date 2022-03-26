using System;
using data_structures_and_algorithms;

namespace data_structures_and_algorithms
{
   public class Program
    {
        static void Main(string[] args)
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(10);
            testLink.Insert(15);
            testLink.Insert(18);
            testLink.Insert(20);
            Console.WriteLine(testLink.To_String());
            Console.WriteLine(testLink.Include(10));

        }
    }
}

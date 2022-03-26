using System;
using data_structures_and_algorithms;

namespace data_structures_and_algorithms
{
   public class Program
    {
        static void Main(string[] args)
        {
            Linked_List testLink = new Linked_List();
            testLink.Insert(8);
            testLink.Insert(12);
            testLink.Insert(17);
            testLink.Insert(21);
            Console.WriteLine(testLink.To_String());
            Console.WriteLine(testLink.Include(18));

        }
    }
}

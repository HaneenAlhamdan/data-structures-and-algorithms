using System;
using data_structures_and_algorithms;

namespace data_structures_and_algorithms
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Linked_List<int> testLink = new Linked_List<int>();

            testLink.To_String();
            testLink.Append(22);
            testLink.Append(38);
            testLink.Add_First(7);
            testLink.Add_Before(7, 14);
            testLink.Add_After(7, 3);
            testLink.Search(14);
            testLink.Search(15);
            testLink.Search(1);
            testLink.Search(18);
            testLink.To_String();
            testLink.KthForm(22);


        }
    }
}

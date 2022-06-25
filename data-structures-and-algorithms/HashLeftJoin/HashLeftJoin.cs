using data_structures_and_algorithms.HashTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.HashLeftJoin
{
    public class HashLeftJoin : Hashtable
    {

        public HashLeftJoin(int size) : base(size)
        { }

        public static List<string[]> LEFTJOINs(Hashtable left, Hashtable right)
        {
            if ((left == null && right == null) || (left == null)) { return null; }

            if (right == null)
            {
                List<string[]> leftList = new List<string[]>();
                for (int i = 0; i < left.buckets.Length; i++)
                {
                    HashNode temp = left.buckets[i];
                    while (temp != null)
                    {
                        leftList.Add(new string[] { $"{temp.Key}", $"{temp.Value}" });
                        temp = temp.Next;
                    }
                }
                return leftList;
            }

            List<string[]> arrayList = new List<string[]>();
            for (int i = 0; i < left.buckets.Length; i++)
            {
                HashNode temp = left.buckets[i];
                while (temp != null)
                {
                    arrayList.Add(new string[] { $"{temp.Key}", $"{temp.Value}", $"{right.Get($"{temp.Key}")}" });
                    temp = temp.Next;
                }
            }

            return arrayList;
        }

        public void PrintList(List<string[]> list)
        {
            if (list == null) { Console.WriteLine("List is empty!"); }
            foreach (var array in list)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == null) { Console.Write("NULL"); }
                    Console.Write(array[i]);
                    if (i < array.Length - 1) { Console.Write(", "); }
                }
                Console.Write("] \n");
            }
        }

    }
}

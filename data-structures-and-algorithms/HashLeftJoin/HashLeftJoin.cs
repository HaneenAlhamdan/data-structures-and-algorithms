using data_structures_and_algorithms.HashTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.HashLeftJoin
{
    public class hashLeftJoin 
    {

        public List<string> LeftJoin(Hashtable hashtable1, Hashtable hashtable2)
        {
            if (hashtable1.size == 0 || hashtable2.size == 0)
            {
                throw new Exception("Hashtable is empty");
            }
            List<string> list = new List<string>();

            List<string> hashtable1keys = hashtable1.Keys();
            foreach (var key in hashtable1keys)
            {
                if (hashtable2.Contains(key))
                {
                    list.Add("[" + key + ":" + hashtable1.Get(key).value + "," + hashtable2.Get(key).value + "]");
                }
                else
                {
                    list.Add("[" + key + ":" + hashtable1.Get(key).value + "," + "null" + "]");
                }
            }
            return list;
        }

    }
}

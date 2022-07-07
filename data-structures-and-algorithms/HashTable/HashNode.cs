using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.HashTable
{
    public class HashNode

    {
        public string key;
        public string value;
       
        public HashNode next;

        
        public HashNode(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

    }
}

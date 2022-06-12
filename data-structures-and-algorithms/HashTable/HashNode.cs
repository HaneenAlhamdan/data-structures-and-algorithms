using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.HashTable
{
    public class HashNode

    {
        public string key;
        public string value;
        // Reference to next node
        public HashNode next;

        // Constructor
        public HashNode(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.HashTable
{
    public class HashNode

    {
        public int Key;
        public string Value;
        public HashNode Next;

        /// <summary>
        /// Constructor to set the key and value for each item that we add in the HashTable.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public HashNode(int key, string value)
        {
            Key = key;
            Value = value;
        }

    }
}

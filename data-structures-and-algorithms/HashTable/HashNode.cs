using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.HashTable
{
    public class HashNode

    {
        public string Key;
        public string Value;
        public HashNode Next;

        public HashNode(string key, string value)
        {
            Key = key;
            Value = value;
        }

    }
}

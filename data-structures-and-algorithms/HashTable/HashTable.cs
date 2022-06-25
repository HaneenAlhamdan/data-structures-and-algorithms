using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_structures_and_algorithms.HashTable
{
    public class Hashtable
    {
        public int hashTableSize;
        public HashNode[] buckets;

        
        public Hashtable(int hashSize)
        {
            hashTableSize = hashSize;
            buckets = new HashNode[hashSize];
        }

       
        public void Set(string key, string value)
        {
            int hashedKey = Hash(key);
            if (buckets[hashedKey] == null)
            {
                buckets[hashedKey] = new HashNode(key, value);
            }
            else
            {
                
                HashNode temp = buckets[hashedKey];
               
                while (temp.Next != null || temp.Key == key)
                {
                   
                    if (temp.Key == key)
                    {
                        temp.Value = value;
                        return;
                    }

                    temp = temp.Next;
                }
              
                temp.Next = new HashNode(key, value);
            }
        }

    
        public string Get(string key)
        {
            if (!Contains(key))
            {
                return null;
            }

            int hashedKey = Hash(key);

            HashNode temp = buckets[hashedKey];
            while (temp.Key != key)
            {
                temp = temp.Next;
            }

            return temp.Value;
        }

        
        public bool Contains(string key)
        {
            int hashedKey = Hash(key);
            HashNode temp = buckets[hashedKey];
            while (temp != null)
            {
                if (temp.Key == key)
                {
                    return true;
                }

                temp = temp.Next;
            }

            return false;
        }

      
        public List<string> Keys()
        {
           
            List<string> keys = new List<string>();
       
            List<HashNode> items = buckets.Where(x => x != null).ToList();
            
            foreach (HashNode node in items)
            {
                if (node.Next == null)
                {
                    keys.Add(node.Key);
                }
                else
                {
                    HashNode temp = node;
                    while (temp != null)
                    {
                        keys.Add(temp.Key);
                        temp = temp.Next;
                    }
                }
            }
            return keys;
        }

       
        public int Hash(string key)
        {
            int index = 7;
            for (int i = 0; i < key.Length; i++)
            {
                int asciiVal = (int)key[i] * i;
                index = index * 31 + asciiVal;
            }
            return index % hashTableSize;
        }

    }

}


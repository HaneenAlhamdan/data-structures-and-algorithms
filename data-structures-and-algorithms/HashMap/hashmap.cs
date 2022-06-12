using data_structures_and_algorithms.HashTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.HashMap
{
    public class hashmap
    {
        public string HashmapRepeatedWord(string text)
        {
            // Get the length
            int n = text.Length;
            if (n == 0)
            {
                return "No text provided";
            }
            Hashtable record = new Hashtable(1024);

            // Collecting words
            char[] delimiterChars = { '-', ',', '.', ':', ' ' };
            string[] str = text.ToLower().Split(delimiterChars);
            // frequency of given word

            for (int i = 0; i < str.Length; i++)
            {
                if (record.Get(str[i]) == null)
                {
                    record.Set(str[i], "1");
                }
                else
                    return str[i];
            }
            return "No Repetetion";
        }
    }
}

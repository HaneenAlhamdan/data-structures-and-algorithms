using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.stack_queue_brackets
{
   public class stack_queue_brackets
    {
        public static bool ValidateBrackets(string input)
        {
            if (input == "")
            {
                return false;
            }
            string left = "({[";
            string right = ")}]";

            Stack<char> charStack = new Stack<char>();

            foreach (var item in input)
            {
                if (left.Contains(item))
                {
                    charStack.Push(item);
                }
                else if (right.Contains(item))
                {
                    if (charStack.Count < 1)
                    {
                        return false;
                    }
                  

                    if (right.IndexOf(item) != left.IndexOf(charStack.Pop()))
                    {
                        return false;
                    }
                }
            }
           
            return charStack.Count == 0;
        }
    }
}

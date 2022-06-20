using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.HashLeftJoin
{
    public class Node
    {
        public string Value { get; set; }

        public Node Left;
        public Node Right;

        public Node(string value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}

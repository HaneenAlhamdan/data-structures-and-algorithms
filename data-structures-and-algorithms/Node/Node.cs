using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.Node
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}

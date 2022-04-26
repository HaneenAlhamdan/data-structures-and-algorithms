using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.Trees
{
    public class NodeTree
    {
        public int Value;
        public NodeTree Left, Right;

        public NodeTree(int y)
        {
            Value = y;

            Right = Left = null;
        }
    }
}

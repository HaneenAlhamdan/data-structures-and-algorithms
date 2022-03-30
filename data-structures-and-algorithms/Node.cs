using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms
{
   
        class Node<T>
        {
            public T data;
            public Node<T> next;

            public T Data
            {
                get; set;
            }

            public Node<T> Next

            {
                get; set;
            }

            public Node(T value)
            {
                Data = value;
                Next = null;
            }
        }
    
}


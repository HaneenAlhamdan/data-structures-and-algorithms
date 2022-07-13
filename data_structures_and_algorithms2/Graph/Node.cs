using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms2.Graph
{
    public class Node
    {
        public Object Value { get; set; }
        

        public List<Node> Children { get; set; }
        public List<Edge> Edge { get; set; } = new List<Edge>();

        public bool Visited { get; set; }

        public Node(Object value)
        {
            Value = value;
            Visited = false;
            Children = new List<Node>();
        }
    }
}

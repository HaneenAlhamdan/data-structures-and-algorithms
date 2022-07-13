using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms2.Graph
{
    public class Edge
    {
        public int Weight { get; set; }
        public Node Neighbor { get; set; }
        public Edge(Node neighbor, int weight)
        {
            Neighbor = neighbor;
            Weight = weight;
        }
        public Edge(Node neighbor)
        {
            Neighbor = neighbor;
        }
    }
}

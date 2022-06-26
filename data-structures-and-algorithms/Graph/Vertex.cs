using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.Graph
{
    public class Vertex
    {
        public int value { get; set; }
        public List<GraphNode> edges;

        public Vertex(int value)
        {
            this.value = value;
            this.edges = new List<GraphNode>();
        }
        public void addEdge(Vertex endVertex, int weight)
        {
            this.edges.Add(new GraphNode(this, endVertex, weight));
        }
    }
}

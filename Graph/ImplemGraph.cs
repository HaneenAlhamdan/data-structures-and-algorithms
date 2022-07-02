using data_structures_and_algorithms.HashLeftJoin;
using System.Collections.Generic;
using Xunit;
using data_structures_and_algorithms.HashLeftJoin;

namespace Graph
{
    public class ImplemGraph
    {
        [Fact]
        public void AddNodeTest()
        {
            ImplemGraph graph = new ImplemGraph();
            graph.AddNode("Apple");
            Node node = graph.GetNode("Apple");
            Assert.NotNull(node);
        }

        [Fact]
        public void AddEdgeTest()
        {
            ImplemGraph graph = new ImplemGraph();
            graph.AddNode("Apple");
            graph.AddNode("Orange");
            graph.AddEdge("Apple", "Orange", 100);

            var OsamaNeighbors = graph.GetNeighbors("Apple");
            var RawanNeighbors = graph.GetNeighbors("Orange");

            Assert.True(OsamaNeighbors.ContainsKey("Orange"));
            Assert.True(RawanNeighbors.ContainsKey("Apple"));
        }

        [Fact]
        public void GetNodesTest()
        {
            ImplemGraph graph = new ImplemGraph();
            graph.AddNode("Apple");
            graph.AddNode("Orange");
            HashSet<Node> test = new HashSet<Node>();
            test.Add(graph.GetNode("Apple"));
            test.Add(graph.GetNode("Orange"));

            HashSet<Node> nodes = graph.GetNodes();
            Assert.Equal(test, nodes);
        }

        [Fact]
        public void GetVertexNeighborsTest()
        {
            ImplemGraph graph = new ImplemGraph();
            graph.AddNode("Apple");
            graph.AddNode("Orange");
            graph.AddNode("Banana");
            graph.AddNode("Grape");
            graph.AddEdge("Apple", "Orange", 100);
            graph.AddEdge("Apple", "Banana", 100);
            graph.AddEdge("Apple", "Grape", 100);
            var neighbors = graph.GetNeighbors("Apple");

            Assert.True(neighbors.ContainsKey("Orange")); Assert.True(neighbors.ContainsKey("Banana")); Assert.True(neighbors.ContainsKey("Grape"));
        }

        [Fact]
        public void GetWeightTest()
        {
            ImplemGraph graph = new ImplemGraph();
            graph.AddNode("Apple");
            graph.AddNode("Orange");
            graph.AddEdge("Apple", "Orange", 100);
            var weight = graph.GetNode("Apple").Neighbors["Orange"];

            Assert.Equal(100, weight);
        }

        [Fact]
        public void GetSizeTest()
        {
            ImplemGraph graph = new ImplemGraph();
            graph.AddNode("Apple");
            graph.AddNode("Orange");
            Assert.Equal(2, graph.Size());
        }

        [Fact]
        public void NullGraphTest()
        {
            ImplemGraph graph = new ImplemGraph();
            Assert.Null(graph.GetNodes());
        }
    }
}

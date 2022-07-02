using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Graph.ImplemGraph
{
    public class BusinessTrip
    {
        [Fact]
            public void EmptyGraphTest()
            {
            Graph graph = new Graph();
                Assert.Null(graph.BusinessTrip(null, new string[] { "Apple", "Orange" }));

            }

            [Fact]
            public void EmptyArrayTest()
            {
                Graph graph = new Graph();
                Assert.Null(graph.BusinessTrip(graph, null));
            }

            [Fact]
            public void OneCityTest()
            {
                Graph graph = new Graph();
                Assert.Null(graph.BusinessTrip(graph, new string[] { "Amman" }));
            }

            [Fact]
            public void UnvalidVertextTest()
            {
                Graph graph = new Graph();
                graph.AddNode("Apple"); graph.AddNode("Orange"); graph.AddNode("Banana");
                graph.AddEdge("Apple", "Banana", 10);
                graph.AddEdge("Banana", "Orange", 10);
                Assert.Null(graph.BusinessTrip(graph, new string[] { "Grape", "Orange" }));
            }

            [Fact]
            public void ValidTest()
            {
                Graph graph = new Graph();
                graph.AddNode("Apple"); graph.AddNode("Orange"); graph.AddNode("Banana");
                graph.AddEdge("Apple", "Banana", 10);
                graph.AddEdge("Banana", "Orange", 10);
                Assert.Equal(20, graph.BusinessTrip(graph, new string[] { "Apple", "Banana", "Orange" }));
            }

            [Fact]
            public void NoPathTest()
            {
                Graph graph = new Graph();
                graph.AddNode("Apple"); graph.AddNode("Orange"); graph.AddNode("Banana");
                graph.AddEdge("Apple", "Banana", 10);
                graph.AddEdge("Banana", "Orange", 10);
                Assert.Null(graph.BusinessTrip(graph, new string[] { "Apple", "Orange" }));
            }
        
    }
}

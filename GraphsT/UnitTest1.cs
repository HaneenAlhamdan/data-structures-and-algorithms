using data_structures_and_algorithms2;
using data_structures_and_algorithms2.Graph;
using System;
using System.Collections.Generic;
using Xunit;

namespace GraphsT
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Graphs graph = new Graphs();

            Node Pandora = new Node("Pandora");
            Node Arendelle = new Node("Arendelle");
            Node Metroville = new Node("Metroville");
            Node Monstroplolis = new Node("Monstroplolis");
            Node Narnia = new Node("Narnia");
            Node Naboo = new Node("Naboo");


            graph.AddNode("Pandora");
            graph.AddNode("Arendelle");
            graph.AddNode("Metroville");
            graph.AddNode("Monstroplolis");
            graph.AddNode("Narnia");
            graph.AddNode("Naboo");


            graph.AddEdge(Pandora, Arendelle, 150);
            graph.AddEdge(Pandora, Monstroplolis, 99);
            graph.AddEdge(Arendelle, Metroville, 82);
            graph.AddEdge(Arendelle, Monstroplolis, 105);
            graph.AddEdge(Monstroplolis, Naboo, 26);
            graph.AddEdge(Monstroplolis, Narnia, 13);



            List<Node> depthFirst = graph.DepthFirst(graph);
            List<Object> result = new List<object>();
            foreach (var item in depthFirst)
            {
                result.Add(item.Value);
            }
            List<Object> expected = new List<Object> { "Pandora", "Arendelle", "Metroville", "Monstroplolis", "Naboo", "Narnia" };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DepthFirstEmptyTest()
        {
            Graphs graph = new Graphs();

            List<Node> result = graph.DepthFirst(graph);

            Assert.Null(result);
        }

    }
    
}

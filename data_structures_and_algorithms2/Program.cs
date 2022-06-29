using data_structures_and_algorithms.Trees;
using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new NodeTree(1);
            tree1.Root.Left = new NodeTree(2);
            tree1.Root.Right = new NodeTree(13);
            tree1.Root.Left.Left = new NodeTree(4);
            tree1.Root.Left.Right = new NodeTree(5);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new NodeTree(2);
            tree2.Root.Left = new NodeTree(23);
            tree2.Root.Right = new NodeTree(3);
            tree2.Root.Left.Left = new NodeTree(6);
            tree2.Root.Left.Right = new NodeTree(5);

            TreeIntersection tree_Intersection = new TreeIntersection();
            List<int> intersections = tree_Intersection.Tree_Intersection(tree1, tree2);

            Console.WriteLine("The Intersections: ");
            foreach (int value in intersections)
            {
                Console.Write(value + " ");
            }

            /////////////////////////////////////////////////////////////

            Console.WriteLine("\n");

            Graph graph = new Graph();
            graph.AddNode("Pandora");
            graph.AddNode("Arendelle");
            graph.AddNode("Metroville");
            graph.AddNode("Monstroplolis");
            graph.AddNode("Narnia");
            graph.AddNode("Naboo");

            graph.AddEdge("Pandora", "Arendelle", 150);
            graph.AddEdge("Pandora", "Metroville", 82);
            graph.AddEdge("Arendelle", "Monstroplolis", 42);
            graph.AddEdge("Arendelle", "Metroville", 99);
            graph.AddEdge("Metroville", "Naboo", 26);
            graph.AddEdge("Metroville", "Narnia", 37);
            graph.AddEdge("Monstroplolis", "Naboo", 73);
            graph.AddEdge("Monstroplolis", "Metroville", 105);
            graph.AddEdge("Naboo", "Narnia", 250);

            Console.WriteLine("Result is " + graph.BusinessTrip(graph, new string[] { "Arendelle", "Monstroplolis", "Naboo" }));
        }
    }
}

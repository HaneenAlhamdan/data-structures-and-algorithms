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
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");

            graph.AddEdge("A", "B", 55);
            graph.AddEdge("A", "C", 71);
            graph.AddEdge("B", "D", 33);
            graph.AddEdge("B", "C", 29);
            graph.AddEdge("C", "F", 101);
            graph.AddEdge("C", "E", 84);
            graph.AddEdge("D", "F", 62);
            graph.AddEdge("D", "C", 15);
            graph.AddEdge("F", "E", 123);

            Console.WriteLine("Graph:" + graph.BusinessTrip(graph, new string[] {"B", "D", "F" }));
        }
    }
}

using data_structures_and_algorithms.Trees;
using System;
using System.Collections.Generic;
using data_structures_and_algorithms2.Graph;

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
            Console.Write("Depth first graph: at root Pandora: ");
            foreach (Node node in depthFirst)
            {
                Console.Write($" {node.Value} ");
            }
            Console.WriteLine();
        }
    }




}
    



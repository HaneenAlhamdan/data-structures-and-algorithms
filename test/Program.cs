using data_structures_and_algorithms.Trees;
using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

            Console.WriteLine("intersections are: ");
            foreach (int value in intersections)
            {
                Console.Write(value + " ");
            }
        }
    }
}

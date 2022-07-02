using data_structures_and_algorithms.Trees;
using data_structures_and_algorithms2;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tree
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            BinaryTree tree = new BinaryTree();
            tree.Root = new NodeTree(1);
            tree.Root.Left = new NodeTree(2);
            tree.Root.Right = new NodeTree(13);
            tree.Root.Left.Left = new NodeTree(4);
            tree.Root.Left.Right = new NodeTree(5);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new NodeTree(11);
            tree2.Root.Left = new NodeTree(23);
            tree2.Root.Right = new NodeTree(3);
            tree2.Root.Left.Left = new NodeTree(6);
            tree2.Root.Left.Right = new NodeTree(5);

            TreeIntersection tree_Intersection = new TreeIntersection();
            List<int> intersections = tree_Intersection.Tree_Intersection(tree, tree2);
            List<int> expected = new List<int>() { 5 };
            Assert.Equal(expected, intersections);
        }
        [Fact]
        public void Test2()
        {

            BinaryTree tree = new BinaryTree();
            tree.Root = new NodeTree(1);
            tree.Root.Left = new NodeTree(2);
            tree.Root.Right = new NodeTree(13);
            tree.Root.Left.Left = new NodeTree(4);
            tree.Root.Left.Right = new NodeTree(5);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new NodeTree(11);
            tree2.Root.Left = new NodeTree(23);
            tree2.Root.Right = new NodeTree(3);
            tree2.Root.Left.Left = new NodeTree(6);
            tree2.Root.Left.Right = new NodeTree(5);

            TreeIntersection tree_Intersection = new TreeIntersection();
            List<int> intersections = tree_Intersection.Tree_Intersection(tree, tree2);
            List<int> expected = new List<int>() { 5, 23 };
            Assert.NotEqual(expected, intersections);
        }
        [Fact]
        public void Test3()
        {

            BinaryTree tree = new BinaryTree();
            BinaryTree tree2 = new BinaryTree();
            tree.Root = null;
            tree2.Root = new NodeTree(11);
            TreeIntersection tree_Intersection = new TreeIntersection();
            Exception ex = Assert.Throws<Exception>(() => tree_Intersection.Tree_Intersection(tree, tree2));
            Assert.Equal("Tree is empty", ex.Message);

        }
    }
}

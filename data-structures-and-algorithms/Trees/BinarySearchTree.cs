using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.Trees
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int value)
        {
            NodeTree curNode;
            NodeTree parentNode;
            NodeTree node = new NodeTree(value);
            if (Root != null)
            {
                curNode = Root;

                while (true)
                {
                    parentNode = curNode;
                    if (value < curNode.Value)
                    {
                        curNode = curNode.Left;
                        if (curNode == null)
                        {
                            parentNode.Left = node;
                            break;
                        }
                    }
                    else
                    {
                        curNode = curNode.Right;
                        if (curNode == null)
                        {
                            parentNode.Right = node;
                            break;
                        }
                    }
                }
            }
            else
            {
                Root = node;
            }
        }
        //    public void Add(int value)
        //    {
        //        NodeTree newNode = new NodeTree(value);
        //        if (Root == null)
        //        {
        //            Root = newNode;
        //        }
        //        else
        //        {
        //            NodeTree current = Root;
        //            NodeTree parent;
        //            while (true)
        //            {
        //                parent = current;
        //                if (value < parent.Value)
        //                {
        //                    current = current.Left;
        //                    if (current == null)
        //                    {
        //                        parent.Left = newNode;
        //                        return;
        //                    }
        //                }
        //                else
        //                {
        //                    current = current.Right;
        //                    if (current == null)
        //                    {
        //                        parent.Right = newNode;
        //                        return;
        //                    }
        //                }
        //            }
        //        }   
        //}
        public bool Contains(int value)
        {
            NodeTree node = Root;
            while (node != null)
            {
                if (node.Value == value)
                {
                    return true;
                }
                if (node.Value > value)
                {
                    node = node.Left;

                }
                else
                {
                    node = node.Right;
                }
            }
            return false;
        }
    }
}

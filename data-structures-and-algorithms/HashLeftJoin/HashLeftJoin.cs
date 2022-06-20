using data_structures_and_algorithms.HashTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.HashLeftJoin
{
    public class HashLeftJoin 
    {

        public Node Root { get; set; }
        public List<object> List = new List<object>();

        public HashLeftJoin()
        {
            Root = null;
        }

        public Node GetRoot()
        {
            return Root;
        }
        public void Inorder()
        {
            Inorder(Root);
            Console.WriteLine("");
        }
        public object[] Inorder(Node node)
        {
            if (node == null)
                return null;


            Inorder(node.Left);
            List.Add(node.Value);
            Console.Write(node.Value + " ");
            Inorder(node.Right);
            return List.ToArray();

        }

        public void Preorder()
        {
            Preorder(Root);
            Console.WriteLine("");

        }
        public object[] Preorder(Node node)
        {
            if (node == null)
                return null;

            List.Add(node.Value);
            Console.Write(node.Value + " ");
            Preorder(node.Left);
            Preorder(node.Right);
            return List.ToArray();

        }



        public void Postorder()
        {
            Postorder(Root);
            Console.WriteLine("");

        }
        public object[] Postorder(Node node)
        {
            if (node == null)
                return null;


            Postorder(node.Left);
            Postorder(node.Right);
            List.Add(node.Value);
            Console.Write(node.Value + " ");
            return List.ToArray();
        }

        public void BreadthFirst()
        {
            BreadthFirst(Root);

        }

        public List<string> BreadthFirst(Node root)
        {
            List<string> treeValues = new List<string>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            treeValues.Add(root.Value);
            while (queue.Count != 0)
            {
                Node tempNode = queue.Dequeue();
                Console.Write(tempNode.Value + " ");

                /*Enqueue left child */
                if (tempNode.Left != null)
                {
                    queue.Enqueue(tempNode.Left);
                    treeValues.Add(tempNode.Left.Value);
                }

                /*Enqueue right child */
                if (tempNode.Right != null)
                {
                    queue.Enqueue(tempNode.Right);
                    treeValues.Add(tempNode.Right.Value);

                }
            }
            return treeValues;
        }

    }
}

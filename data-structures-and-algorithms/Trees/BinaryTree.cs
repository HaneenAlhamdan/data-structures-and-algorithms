using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.Trees
{
	public class BinaryTree
	{
		
		public NodeTree Root;
		public List<int> list = new List<int>();
		public BinaryTree()
		{
			
			Root = null;
		}
		public int[] PreOrder(NodeTree Root)
		{
			if (Root == null)
			{
				throw new Exception("Tree is empty");
			}
			list.Add(Root.Value);

			if (Root.Left != null)
			{
				PreOrder(Root.Left);

			}
			if (Root.Right != null)
			{
				PreOrder(Root.Right);
			}
			return list.ToArray();
		}
		public int[] InOrder(NodeTree Root)
		{

			if (Root == null)
			{
				throw new Exception("Tree is empty");
			}
			if (Root.Left != null)
			{
				InOrder(Root.Left);
			}
			list.Add(Root.Value);

			if (Root.Right != null)
			{
				InOrder(Root.Right);
			}
			return list.ToArray();
		}
		public int[] PostOrder(NodeTree Root)
		{

			if (Root == null)
			{
				throw new Exception("Tree is empty");
			}
			if (Root.Left != null)
			{
				PostOrder(Root.Left);
			}
			if (Root.Right != null)
			{
				PostOrder(Root.Right);
			}
			list.Add(Root.Value);
			return list.ToArray();
		}


		public int Maximum()
		{
			var result = Root.Value;
			var q = new Queue();
			q.Enqueue(Root);

			while (q.Count != 0)
			{
				NodeTree node = (NodeTree)q.Peek(); 

				if (node.Left != null)
				{
					q.Enqueue(node.Left);
				}
				if (node.Right != null)
				{
					q.Enqueue(node.Right);
				}
				if (node.Value > result)
				{
					result = node.Value;
				}
				q.Dequeue();
			}
			return result;
		}


		public List<int> BreadthFirst(BinaryTree tree)
		{
			if (Root == null)
			{
				throw new Exception("Tree is empty");
			}
			Queue<NodeTree> q = new Queue<NodeTree>();
			List<int> result = new List<int>();
			q.Enqueue(tree.Root);
			while (q.Count > 0)
			{
				NodeTree Front = q.Peek();
				result.Add(Front.Value);
				q.Dequeue();
				if (Front == null)
				{
					continue;
				}
				if (Front.Left != null)
				{
					q.Enqueue(Front.Left);
				}
				if (Front.Right != null)
				{
					q.Enqueue(Front.Right);
				}
			}
			return result;
		}



		public void FizzBuzzTree(BinaryTree tree)
		{
			Traverse(tree.Root);
		}
		
		public List<string> Traverse(NodeTree node)
		{
			if (Root == null)
			{
				throw new Exception("Tree is empty");
			}

			List<string> listTree = new List<string>();
			if (node.Value % 15 == 0)
			{
				listTree.Add("FizzBuzz");
				Console.WriteLine($"{node.Value}: FizzBuzz");
			}
			else if (node.Value % 5 == 0)
			{
				listTree.Add("Buzz");
				Console.WriteLine($"{ node.Value}: Buzz");
			}
			else if (node.Value % 3 == 0)
			{
				listTree.Add("Fizz");
				Console.WriteLine($"{ node.Value}: Fizz");
			}
			else
			{
				listTree.Add($"{node.Value}");
				Console.WriteLine($"{node.Value}:\'{node.Value}\'");
			}
			if (node.Left != null)
			{
				Traverse(node.Left);
			}
			if (node.Right != null)
			{
				Traverse(node.Right);
			}
			return listTree;
		}
	}
}

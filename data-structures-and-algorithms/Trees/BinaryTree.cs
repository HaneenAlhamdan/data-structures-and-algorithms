using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.Trees
{
	public class BinaryTree
	{
		// Root of Binary Tree
		public NodeTree Root;
		public List<int> list = new List<int>();
		public BinaryTree()
		{
			// Set initial tree root
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
			// Add first node of tree
			q.Enqueue(Root);

			while (q.Count != 0)
			{
				NodeTree node = (NodeTree)q.Peek(); // Get new head

				if (node.Left != null)
				{
					// Add left child value
					q.Enqueue(node.Left);
				}
				if (node.Right != null)
				{
					// Add right child value
					q.Enqueue(node.Right);
				}
				// Check that node value is greater than or not
				if (node.Value > result)
				{
					result = node.Value;
				}
				// Remove element of queue
				q.Dequeue();
			}
			return result;
		}
	}
}

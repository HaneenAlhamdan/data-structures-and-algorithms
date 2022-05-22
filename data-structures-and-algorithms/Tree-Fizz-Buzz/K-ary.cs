using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_structures_and_algorithms.Tree_Fizz_Buzz
{
	public class K_ary
    {

        public string Value { get; set; }
        public List<K_ary> Children { get; set; }

        public K_ary()
        {

        }

        public K_ary(string data)
        {
            Value = data;
            Children = new List<K_ary>();
        }

        public K_ary(string data, List<K_ary> child)
        {
            Value = data;
            Children = child;
        }

        public List<string> FizzBuzz(K_ary root)
        {
            List<string> list = new List<string>();
            if (root == null)
            {
                return null;
            }
            Queue<K_ary> queue = new Queue<K_ary>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int len = queue.Count();
                for (int i = 0; i < len; i++)
                {
                    int value = Convert.ToInt32(queue.First().Value);
                    if (value % 15 == 0)
                    {
                        list.Add("FizzBuzz");
                    }
                    else if (value % 3 == 0)
                    {
                        list.Add("Fizz");
                    }
                    else if (value % 5 == 0)
                    {
                        list.Add("Buzz");
                    }
                    else
                    {
                        list.Add(queue.First().Value);
                    }
                    K_ary node = queue.Dequeue();
                    foreach (K_ary item in node.Children)
                    {
                        queue.Enqueue(item);
                    }
                }
            }
            return list;
        }
        public List<string> Traverse(K_ary root)
        {
            List<string> list = new List<string>();
            if (root == null)
            {
                return null;
            }
            Queue<K_ary> queue = new Queue<K_ary>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int len = queue.Count();
                for (int i = 0; i < len; i++)
                {
                    K_ary node = queue.Dequeue();
                    list.Add(node.Value);
                    foreach (K_ary item in node.Children)
                    {
                        queue.Enqueue(item);
                    }
                }
            }
            return list;
        }

    }
}

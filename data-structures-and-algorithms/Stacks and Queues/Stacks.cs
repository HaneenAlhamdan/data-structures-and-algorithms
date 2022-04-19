using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data_structures_and_algorithms.Node;
using data_structures_and_algorithms.stack_queue_pseudo;

namespace data_structures_and_algorithms.Stacks_and_Queues
{
    public class Stack
    {
        public Node.Node top;
        public Stack()
        {
            top = null;
        }

        public void Push(int value)
        {
            Node.Node newNode = new Node.Node(value);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("Push the number in to stack {0}", value);
        }

        public int? Pop()
        {
            try
            {
                if (top == null)
                {
                    throw new Exception("It can't delete from stack");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            Node.Node temp = top;
            Console.WriteLine("Pop the number {0}", top.data);
            top = top.next;

            return temp.data;
        }

        public int? Peek()
        {
            try
            {
                if (top == null)
                {
                    throw new Exception("Stack is empty.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            Console.WriteLine("Top of Stack: {0}", top.data);

            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}


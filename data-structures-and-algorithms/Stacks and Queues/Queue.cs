using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data_structures_and_algorithms.Node;

namespace data_structures_and_algorithms.Stacks_and_Queues
{
   
    public class Queue
    {
        public Node.Node front;
        public Node.Node rear;

        public Queue()
        {
            front = rear = null;
        }

        public void Enqueue(int item)
        {
            Node.Node newNode = new Node.Node(item);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            Console.WriteLine("Insert the number in to Queue {0}", item);
        }

        public int? Dequeue()
        {
            try
            {
                if (front == null)
                {
                    throw new Exception("Queue is empty");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            Node.Node temp = front;
            front = front.next;

            if (front == null)
            {
                rear = null;
            }

            Console.WriteLine("Dequeued the number {0}", temp.data);
            return temp.data;
        }

        public int? Peek()
        {
            try
            {
                if (front == null)
                {
                    throw new Exception("Queue is empty");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return front.data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}

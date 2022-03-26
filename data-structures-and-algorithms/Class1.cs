using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms
{
    public class Linked_List
    {
        public Node head;

        public void Insert(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public bool Include(int data)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public string To_String()
        {
            string outPut = "";
            Node temp = head;
            while (temp != null)
            {
                outPut += $"[{temp.data}] -> ";
                temp = temp.next;
            }
            outPut += "NULL";
            return outPut;
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    }

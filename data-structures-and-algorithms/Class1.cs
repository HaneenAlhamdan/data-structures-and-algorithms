using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms
{

    public class Linked_List<T>
    {
        Node<T> Head { get; set; }
        Node<T> Tail { get; set; }

        public Linked_List()
        {
            Head = null;
            Tail = null;
        }
        
        public void Add_Before(T node, T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
            }
            Node<T> current = Head;
            if (Head.Data.Equals(node))
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = current.Next;
                Head = newNode;
                newNode.Next = current;
            }
            else if (Head.next == null)
            {
                Console.WriteLine("Add Before node not exsist");
            }
            else
            {
                while (!current.Next.Data.Equals(node))
                {
                    if (current.Next == null)
                    {
                        Console.WriteLine("Node not exsist");
                        break;
                    }
                    else
                    {
                        current = current.Next;
                        if (current.Next == null)
                        {
                            break;
                        }
                    }
                }
                if (current.Next == null)
                {
                    Console.WriteLine("Add Before node not exsist");
                }
                else
                {
                    Node<T> newNode = new Node<T>(data);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
        }
       
        public void Add_After(T node, T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
            }

            Node<T> current = Head;
            if (Head.Data.Equals(node))
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            else
            {
                while (!current.Data.Equals(node))
                {
                    if (current.Next == null)
                    {
                        break;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                if (current.Next == null)
                {
                    Console.WriteLine("Add After node not exsist");
                }
                else
                {
                    Node<T> newNode = new Node<T>(data);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
        }
       
        public void Append(T value)
        {
            Node<T> item = new Node<T>(value);

            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
        }
        
        public void To_String()
        {
            Node<T> start = Head;
            if (start == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.Write("Head ->");
                while (start != null)
                {
                    Console.Write("[" + start.Data + "] -> ");
                    start = start.Next;
                }
                Console.WriteLine("Null");
            }
        }
       
        public void Add_First(T value)
        {
            Node<T> item = new Node<T>(value);

            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                item.Next = Head;
                Head = item;
            }
        }
        
        public bool Search(T value)
        {
            Node<T> current = new Node<T>(value);
            current = Head;
            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    Console.WriteLine("Found");
                    return true;
                }
                current = current.Next;
            }
            if (current == null)
            {
                Console.WriteLine("Not found");
            }
            return false;
        }
    }
    }

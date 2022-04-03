﻿using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms
{

    public class Linked_List<H>
    {
        Node<H> Head { get; set; }
        Node<H> Tail { get; set; }

        public Linked_List()
        {
            Head = null;
            Tail = null;
        }
        
        public void Add_Before(H node, H data)
        {
            if (Head == null)
            {
                Head = new Node<H>(data);
            }
            Node<H> current = Head;
            if (Head.Data.Equals(node))
            {
                Node<H> newNode = new Node<H>(data);
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
                    Node<H> newNode = new Node<H>(data);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
        }
       
        public void Add_After(H node, H data)
        {
            if (Head == null)
            {
                Head = new Node<H>(data);
            }

            Node<H> current = Head;
            if (Head.Data.Equals(node))
            {
                Node<H> newNode = new Node<H>(data);
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
                    Node<H> newNode = new Node<H>(data);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
        }
       
        public void Append(H value)
        {
            Node<H> item = new Node<H>(value);

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
            Node<H> start = Head;
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
                Console.WriteLine("X");
            }
        }
       
        public void Add_First(H value)
        {
            Node<H> item = new Node<H>(value);

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
        
        public bool Search(H value)
        {
            Node<H> current = new Node<H>(value);
            current = Head;
            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    Console.WriteLine("Found "+ value);
                    return true;
                }
                current = current.Next;
            }
            if (current == null)
            {
                Console.WriteLine("Not found "+ value);
            }
            return false;
        }
        public bool KthForm( int value)
        {
            if(value<0)
            {
                return false;
            }

            int count = 0;
            Node<H> prev, current, next;
            prev = null;
            current = Head;
            if(Head==null)
            {
                Console.WriteLine("List is empty");
                return false;
            }
            while(current!=null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Head = prev;
            while (!Head.Data.Equals(null))
            {
                if (Head.Next == null)
                {
                    break;
                }
                else
                {
                    count++;
                    Head = Head.Next;
                }
                if (count == value)
                {
                    Console.WriteLine(Head.Data);
                    return true;
                }
                else
                {
                    Console.WriteLine("List size less than{value}");

                }
                return false;
            
                }
            }
        }
    }
    

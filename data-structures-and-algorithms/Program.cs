using System;


namespace data_structures_and_algorithms
{
   public class Program
    {
        public class Node
        {
            public String data;
            private Node nextNode;


            public Node(String data)
            {
                this.data = data;
            }

            public String getData()
            {
                return data;
            }

            public Node getNext()
            {
                return nextNode;
            }

            public void setNext(Node nextNode)
            {
                this.nextNode = nextNode;
            }
        }

        public class LinkedList
        {
            private Node head;
            private int size = 0;


            public void insert(String data)
            {
                Node node = new Node(data);

                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node tempRef = head.getNext();
                    node.setNext(tempRef);
                    head.setNext(node);
                }
                size++;
            }

          
            public bool includes(String data)
            {
                Node currentNode = head;
                while (currentNode.getNext() != null)
                {
                    if (currentNode.getData() == data)
                    {
                        return true;
                    }
                    currentNode = currentNode.getNext();
                }
                return false;
            }

            
           
      public String toString()
            {
                String linkesListToString = "";

                if (head == null)
                {
                    return "Empty LinkedList (*_*)";
                }
                else
                {
                    Node currentNode = head;
                    while (currentNode != null)
                    {
                        linkesListToString = linkesListToString + "{ " + currentNode.getData() + " } -> ";
                        currentNode = currentNode.getNext();
                    }
                    currentNode = null;
                }
                return linkesListToString + "NULL";
            }
        }

    }
}

//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;
//using System.Threading.Tasks;

//namespace data_structures_and_algorithms.Node
//{


//    public class Linked_List
//    {
//        public Node head;
//        public static int counter = 0;
//        public int GetCounter()
//        {
//            return counter;
//        }
  

//        public void Append(int data)
//        {
//            if (head == null)
//            {
//                Node newNode = new Node(data);
//                newNode.next = head;
//                head = newNode;
//            }
//            else
//            {
//                Node temp = head;
//                while (temp.next != null)
//                {
//                    temp = temp.next;
//                }
//                Node newNode = new Node(data);
//                temp.next = newNode;
//            }
//        }
//        public void Add_Before(int oldValue, int newValue)
//        {
//            if (head == null)
//            {
//                Console.WriteLine("Linked list is empty!");
//            }
//            else if (Includes(oldValue))
//            {
//                Node temp = head;
//                Node node = new Node(newValue);
//                if (temp.next == null)
//                {
//                    node.next = temp;
//                    head = node;
//                }
//                else if (temp.data == oldValue)
//                {
//                    node.next = temp;
//                    head = node;
//                }
//                else
//                {
//                    while (temp.next.data != oldValue)
//                    {
//                        temp = temp.next;
//                    }

//                    node.next = temp.next;
//                    temp.next = node;
//                }
//            }
//            else
//            {
//                Console.WriteLine("It can't Insert!");
//            }
//        }
//        public void Add_After(int oldValue, int newValue)
//        {
//            if (head == null)
//            {
//                Console.WriteLine("Linked list is empty!");
//            }
//            else if (Includes(oldValue))
//            {
//                Node temp = head;
//                while (temp.data != oldValue)
//                {
//                    temp = temp.next;
//                }
//                Node newNode = new Node(newValue);
//                if (temp.next != null)
//                {
//                    newNode.next = temp.next;
//                    temp.next = newNode;
//                }
//                else
//                {
//                    temp.next = newNode;
//                }
//            }
//            else
//            {
//                Console.WriteLine("It can't Insert!");
//            }
//        }
//        public void DeleteNode(int data)
//        {
//            if (Includes(data))
//            {
//                counter--;
//                Node temp = head;
//                Node prev = null;
//                if (temp != null && temp.data == data)
//                {
//                    head = temp.next;
//                    return;
//                }
//                while (temp != null && temp.data != data)
//                {
//                    prev = temp;
//                    temp = temp.next;
//                }
//                if (temp == null)
//                {
//                    return;
//                }
//                prev.next = temp.next;
//            }
//            else
//            {
//                Console.WriteLine("You can't ,it not exist!");
//            }
//        }
//        public void Insert(int data)
//        {
//            Node newNode = new Node(data);
//            newNode.next = head;
//            head = newNode;
//        }

//        public bool Includes(int data)
//        {
//            Node temp = head;
//            while (temp != null)
//            {
//                if (temp.data == data)
//                {
//                    return true;
//                }
//                temp = temp.next;
//            }
//            return false;
//        }

//        public string To_String()
//        {
//            string outPut = "";
//            Node temp = head;
//            while (temp != null)
//            {
//                outPut += $"[{temp.data}] -> ";
//                temp = temp.next;
//            }
//            outPut += "NULL";
//            return outPut;
//        }


//        public int? KthForm(int k)
//        {
//            try
//            {
//                if (k > counter || k < 0)
//                {
//                    throw new Exception(k + " out of the range");
//                }
//                else
//                {
//                    Node temp = head;
//                    for (int i = 1; i < counter - k; i++)
//                    {
//                        temp = temp.next;
//                    }
//                    //  throw new Exception( "The index for "+k +" is: "+ temp.data);
//                    return temp.data;

//                }
//            }
//            catch (Exception e)
//            {
//                Console.Write(e.Message);
//                return null;
//            }
//        }

//        public static Linked_List list_zip(Linked_List list1, Linked_List list2)
//        {
//            Node before = list1.head;
//            Node current = list2.head;
//            Node after;
            
//            if (before == null)
//            {
//                after = null;
//                current = null;
//                list1.head = list2.head;
//            }
//            else
//            {
//                after = before.next;
//            }
           
//            while (current != null)
//            {
                
//                before.next = current;
                
//                before = current;
//                current = after;
//                after = before.next;
//            }
            
//            list2.head = null;
           
//            return list1;
//        }



//    }
//    //public class Node
//    //{
//    //    public int data;
//    //    public Node next;

//    //    public Node(int data)
//    //    {
//    //        Linked_List.counter++;
//    //        this.data = data;
//    //        next = null;
//    //    }
//    //}
//}


using System;
using System.Collections.Generic;
using System.Text;
using data_structures_and_algorithms.Stacks_and_Queues;
using data_structures_and_algorithms.Node;


namespace data_structures_and_algorithms.stack_queue_pseudo
{
    public class stack_queue_pseudo
    {

        Stack stack1 = new Stack();
        Stack stack2 = new Stack();

        //public void Enqueue(int x)
        //{

        //    while (stack1.IsEmpty() == false)
        //    {
        //        int a;
        //        a = (int)stack1.Pop();
        //        stack2.Push(stack1.Pop());
        //    }

        //    stack1.Push(x);


        //    while (stack2.IsEmpty() == false)
        //    {
        //        stack1.Push(stack2.Pop());
        //    }
        //}

        public object Dequeue()
        {

            if (stack1.IsEmpty() == true)
            {
                return "Q is Empty";

            }

            return stack1.Pop();
        }
        public object Peek()
        {
            return stack1.Peek();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace queuewithtwostacks
{
    class Queue : Stack
    {

        Stack one = new Stack();
        Stack two = new Stack();

        public Queue()
        {
            Head = one;
            Tail = Head;
        }
        public void Enqueue()
        {
            Tail.Next = two;
            Tail = Tail.Next;
        }
    }
}

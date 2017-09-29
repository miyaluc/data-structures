using System;
using System.Collections.Generic;
using System.Text;

namespace queuewithtwostacks
{
    class Stack
    {
        public Node Head
        {
            get; set;
        }
        public Node Tail
        {
            get; set;
        }
        public Stack(int Data)
        {
            Head = new Node(Data);
        }

        public Stack()
        {
        }

        public void Push(int Data)
        {
            Node temp = Head;
            Head = new Node(Data);
            Head.Next = temp;
        }
        public int Pop()
        {
            if(Head == Tail)
            {
                Tail = null;
            }
            Node temp = Head.Next;
            Head.Next = null;
            int value = Head.Data;
            Head = temp;
            return value;
        }
    }
}

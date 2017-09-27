using System;
using System.Collections.Generic;
using System.Text;

namespace stacks_queues
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
        public void Push(int Data)
        {
            Node temp = Head;
            Head = new Node(Data);
            Head.Next = temp;
            PrintNodes();
        }
        public int Pop()
        {
            if (Head == Tail)
            {
                Tail = null;
            }
            Node temp = Head.Next;
            Head.Next = null;
            int value = Head.Data;
            Head = temp;
            return value;
        }

        //my print method needs work
        public void PrintNodes()
        {
            Console.Write("Head ->->->");
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.WriteLine("curr.Data");
                Console.WriteLine("");
            }
            Console.Write("->->-> Tail");
        }
    }
}

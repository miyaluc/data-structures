using System;
using System.Collections.Generic;
using System.Text;

namespace stacks_queues
{
    class Queue
    {
        public Node Head
        {
            get; set;
        }
        public Node Tail
        {
            get; set;
        }
        public Queue(int Data)
        {
            Head = new Node(Data);
            Tail = Head;
        }
        public void Enqueue(int Data)
        {
            Tail.Next = new Node(Data);
            Tail = Tail.Next;
        }
        public int Dequeue()
        {
            if(Head == Tail)
            {
                Node temp = Head.Next;
                Head.Next = null;
                int value = Head.Data;
                Head = temp;
                return value;
            }
            else
            {
                return 0;
            }
        }

        //my print method needs work
        public void PrintNodes()
        {
            Console.WriteLine("A queue.");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.WriteLine("This is the beginning of the line. ->->");
            Console.WriteLine("");
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.WriteLine(curr.Data);
                Console.WriteLine("");
            }
            Console.Write("<-<- This is the end of the line.");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}

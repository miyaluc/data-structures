using System;
using System.Collections.Generic;
using System.Text;

namespace single_node_deletion
{
    class LinkedList
    {
        //properties
        public Node head;
        public Node curr;
        public int count = 0;
        public int midCount;
        //if remainder is odd, add to midCount

        public LinkedList(Object data)
        {
            head = new Node(data);
            curr = head;
        }
        public void Add(Object data)
        {
            Node newNode = new Node(data);
            newNode.Data = data;
            curr.Next = newNode;
            curr = newNode;
            count++;
            if (count % 2 == 1)
            {
                midCount++;
            }
        }
        public void PrintNodes()
        {
            Console.Write("Head ->->->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.WriteLine(curr.Data);
                Console.WriteLine("");
            }
            Console.Write("->->-> Tail");
            Console.WriteLine("");
        }
        public void PrintMiddle()
        {
            Console.Write("Head ->->->");
            Console.WriteLine("");
            int start = 0;
            Node curr = head;
            while (start < midCount)
            {
                curr = curr.Next;
                Console.WriteLine(curr.Data);
                Console.Write("->");
                start++;
            }
            Console.WriteLine("<-<-This is the middle.");
        }
        public void SinglyDeleteNode(int input)
        {
            Node current = head;
            //while current next is not equal to null
            while (current.Next != null)
            {
                //if current next node is equal to input
                if (current.Next.Data.Equals(input))
                {
                    //current next equals current next next 
                    current.Next = current.Next.Next;
                    //Node temp equals current next
                    Node temp = current.Next;
                    //temp next equals null
                    temp.Next = null;
                    Console.WriteLine($"{input} has been removed");
                }
                //current equals current next
                current = current.Next;
            }
            //

            //int index = input;
            //int innerCount = 0;
            ////runner
            //Node curr = head;
            ////walker
            //Node curr2 = head;
            //Console.Write("Head ->");

            //while (curr.Next != null)
            //{
            //    curr = curr.Next;
            //    innerCount++;
            //}

            ////curr2 = curr2.Next;

            ////for (int i = 0; i < innerCount - index; i++)
            ////{
            ////    curr2 = curr2.Next.Next;
            ////    Console.WriteLine(curr2.Data);
            ////    Console.Write("->");
            ////}

            //for (int i = 0; i < index - 1; i++)
            //{
            //    curr2 = curr2.Next;
            //    Console.WriteLine(curr2.Data);
            //    Console.Write("->");
            //}

            //Console.WriteLine("This is the new end.");
        }

    }
}


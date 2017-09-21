﻿using System;
using System.Collections.Generic;
using System.Text;

namespace nth_element
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
                Console.WriteLine("curr.Data");
                Console.WriteLine("");
            }
            Console.Write("->->-> Tail");
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
                Console.Write(curr.Data);
                Console.Write("->");
                start++;
            }
            Console.WriteLine("<-<-This is the middle.");
        }
        public void NthFromEnd(int Nth)
        {
            int counts = 1;
            Node curr = head;
            while(curr.Next != null)
            {
                curr = curr.Next;
                counts++;
            }
            Node curr2 = head;
            for(int i = 0; i < counts - Nth; i++)
            {
                curr2 = curr2.Next;
            }
            Console.WriteLine($"This is the Nth element: {curr2.Data}.");
        }
    }
}

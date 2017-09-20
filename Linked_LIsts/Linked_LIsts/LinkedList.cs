using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_LIsts
{
    //public Node Next
    //{
    //    get; set;
    //}

    public class LinkedList
    {
        private Node head;
        private Node current;
        public int Count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
            current = newNode;
            Count++;
        }
        public void AddAtStart(object data)
        {
            Node newNode = new Node() { Data = data };
            newNode.Next = head.Next;
            head.Next = newNode;
            Count++;
        }
        public void PrintAllNodes()
        {
            //Traverse from head
            Console.Write("Head ->->->->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.WriteLine(curr.Data);
                Console.WriteLine("");
            }
            Console.Write("->->->->Tail");
        }
    }
}

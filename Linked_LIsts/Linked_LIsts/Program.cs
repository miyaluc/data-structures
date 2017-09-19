using System;

namespace Linked_LIsts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList newList = new LinkedList();

            Console.WriteLine("");

            newList.AddAtLast(24);
            newList.AddAtLast(42);
            newList.AddAtLast(6);
            newList.PrintAllNodes();
            Console.WriteLine();

            Console.Read();
        }
    }
}

using binary_tree_traversal;
using System;

namespace binary_search_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tree green = new Tree();
            green.Add(10);
            green.BinaryTraversalAdd(7);
            green.BinaryTraversalAdd(13);
            green.BinaryTraversalAdd(9);
            green.BinaryTraversalAdd(20);
            green.BinaryTraversalAdd(32);
            green.BinaryTraversalAdd(18);

            Console.Write(green);

            Console.Read();
        }

        static void Traversal(node current) 
        {
            while (current.Next != null) 
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
            tail = current;
            Console.WriteLine(tail.Value);
        }
    }
}

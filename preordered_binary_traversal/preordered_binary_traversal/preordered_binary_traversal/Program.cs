﻿using System;

namespace preordered_binary_traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tree Green = new Tree();

            Green.Add(1);
            Green.Root.Left = new Node(2);
            Green.Root.Right = new Node(3);
            Green.Root.Left.Left = new Node(4);
            Green.Root.Left.Right = new Node(5);
            Green.Root.Right.Left = new Node(6);

            Console.WriteLine($"Leaf: {Green.Root.Value}");
            Console.WriteLine($"Leaf: {Green.Root.Left.Value}");
            Console.WriteLine($"Leaf: {Green.Root.Right.Value}");
            Console.WriteLine($"Leaf: {Green.Root.Left.Left.Value}");
            Console.WriteLine($"Leaf: {Green.Root.Left.Right.Value}");
            Console.WriteLine($"Leaf: {Green.Root.Right.Left.Value}");
        }
    }
}

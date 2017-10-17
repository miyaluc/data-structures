using System;
using System.Collections.Generic;
using System.Text;

namespace binary_tree_traversal
{
    class Tree
    {
        public Node Root
        {
            get; set;
        }
        public Node Leaf
        {
            get;
            private set;
        }

        public object Add(int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                return Root.Data;
            }
            else
            {
                Console.WriteLine("The tree has already been planted.");
                return null;
            }
        }
        public void Traverse(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Data);
                Traverse(node.Left);
                Traverse(node.Right);
            }
        }

        public void BinaryTraversalAdd(int data)
        {
            if (data < Root.Data)
            {
                Root.Left = new Node(data);
                Console.WriteLine(Root.Left.Data);
            }
            else if (data > Root.Data)
            {
                Root.Right = new Node(data);
                Console.WriteLine(Root.Right.Data);
            }
            else
            {
                Console.WriteLine("Please add a new number.");
            }
        } 


    }
}

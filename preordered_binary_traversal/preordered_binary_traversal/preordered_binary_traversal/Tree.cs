using System;
using System.Collections.Generic;
using System.Text;

namespace preordered_binary_traversal
{
    class Tree
    {
        public Node Root
        {
            get; set;
        }

        public object Add(object data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                return Root.Value;
            }
            else
            {
                Console.WriteLine("The tree has already been planted.");
                return null;
            }
        }
        public void Traverse(Node node)
        {
            if(node != null)
            {
                Console.WriteLine(node.Value);
                Traverse(node.Left);
                Traverse(node.Right);
            }
        }
        public void BreadthTraversal(Node node)
        {
            Queue<Node> lilQ = new Queue<Node>();

            lilQ.Enqueue(node);

            while (lilQ.Count > 0)
            {
                Node traverse = lilQ.Dequeue();
                Console.WriteLine(traverse.Value);

                if (traverse.Left != null)
                {
                    lilQ.Enqueue(traverse.Left);
                }
                if (traverse.Right != null)
                {
                    lilQ.Enqueue(traverse.Right);
                }
            }

        }

        
    }
}

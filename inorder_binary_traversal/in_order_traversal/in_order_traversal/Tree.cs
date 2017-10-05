using System;
using System.Collections.Generic;
using System.Text;

namespace in_order_traversal
{
    class Tree
    {
        public Node Root
        {
            get; set;
        }
        public object Add(object data)
        {
            if(Root == null)
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
            if (node.Left != null)
            {
                Traverse(node.Left);
                Console.WriteLine(node.Value);
            }
            if (node.Right != null)
            {
                Traverse(node.Right)
            }
        }
}

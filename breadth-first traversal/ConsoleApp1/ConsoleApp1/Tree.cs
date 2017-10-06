using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
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
            if (node != null)
            {
                Console.WriteLine(node.Value);
                Traverse(node.Left);
                Traverse(node.Right);
            }
        }


    }
}

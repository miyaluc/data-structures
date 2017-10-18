using System;
using System.Collections.Generic;
using System.Text;

namespace finding_max_min
{
    class Tree
    {
           public Node Add(Node node, int data)
        {

            if (node == null)
            {
                return (new Node(data));
            }
            else
            {

                if (data <= node.Data)
                {
                    node.Left = Add(node.Left, data);
                }
                else
                {
                    node.Right = Add(node.Right, data);
                }

                return node;
            }
        }

        public int Minimum(Node node)
        {
            Node current = node;

            while (current.Left != null)
            {
                current = current.Left;
            }
            return (current.Data);
        }

        public int Maximum(Node node)
        {
            Node current = node;

            while (current.Right != null)
            {
                current = current.Right;
            }
            return (current.Data);
        }
    }
}

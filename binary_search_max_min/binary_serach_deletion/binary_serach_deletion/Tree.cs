using System;
using System.Collections.Generic;
using System.Text;

namespace binary_serach_deletion
{
    class Tree
    {
        Node root;
        public Tree()
        {
            root = null;
        }
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
        public void DeleteLeaf(int data)
        {
            root = DeleteRec(root, data);
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
        public Node DeleteRec(Node root, int data)
        {
            if (root == null) return root;
            if (data < root.Data)
            {
                root.Left = DeleteRec(root.Left, data);
                Console.WriteLine($"{root.Data} was deleted.");
            }
            else if (data > root.Data)
            {
                root.Right = DeleteRec(root.Right, data);
                Console.WriteLine($"{root.Data} was deleted.");
            }
            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }
                root.Data = Minimum(root.Right);
                root.Right = DeleteRec(root.Right, root.Data);
            }
            return root;
        }
    }
}

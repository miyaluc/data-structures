using System;
using System.Collections.Generic;
using System.Text;

namespace array_to_balanced_BST
{
    class Tree
    {

        static Node root;

        public Node sortedArrayToBST(int[] array, int start, int end)
        {

            if (start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;

            Node node = new Node(array[mid]);

            node.Left = sortedArrayToBST(array, start, mid - 1);

            node.Right = sortedArrayToBST(array, mid + 1, end);

            return node;
        }
        public void preorderedBST(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Data + " ");
            preorderedBST(node.Left);
            preorderedBST(node.Right);
        }
    }
}

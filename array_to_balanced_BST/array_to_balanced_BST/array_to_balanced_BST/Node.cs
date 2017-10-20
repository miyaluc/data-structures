using System;
using System.Collections.Generic;
using System.Text;

namespace array_to_balanced_BST
{
    class Node
    {
        public int Data
        {
            get; set;
        }
        public Node Left
        {
            get; set;
        }

        public Node Right
        {
            get; set;
        }

        public Node(int d)
        {
            Data = d;
            Left = Right = null;
        }
    }
}

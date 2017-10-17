﻿using System;
using System.Collections.Generic;
using System.Text;

namespace binary_tree_traversal
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
        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace finding_max_min
{
    class Node
    {
        public int Data { get; set; }
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
            Left = Right = null;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace binary_serach_deletion
{
    class Node
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
                Left = Right = null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace nth_element
{
    class Node
    {
        public Node Next
        {
            get; set;
        }
        public Object Data
        {
            get; set;
        }
        public Node(Object data)
        {
            Data = data;
            Next = null;
        }
    }
}   


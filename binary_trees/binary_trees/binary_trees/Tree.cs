using System;
using System.Collections.Generic;
using System.Text;

namespace binary_trees
{
    class Tree
    {
        public Node Root { get; set; }

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
       
    }
}

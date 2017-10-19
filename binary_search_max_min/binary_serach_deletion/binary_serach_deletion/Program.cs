using System;

namespace binary_serach_deletion
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree green = new Tree();
            Node root = null;
            root = green.Add(root, 4);
            green.Add(root, 2);
            green.Add(root, 1);
            green.Add(root, 3);
            green.Add(root, 6);
            green.Add(root, 5);
            Console.WriteLine("The minimum value of my tree is " + green.Minimum(root));
            Console.WriteLine("The maximum value of my tree is " + green.Maximum(root));
            green.DeleteRec(root, 3);
            Console.WriteLine("3 was deleted from the tree.");
            Console.Read();
            }
        
    }
}


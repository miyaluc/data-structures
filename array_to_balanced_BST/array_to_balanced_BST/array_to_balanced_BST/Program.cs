using System;

namespace array_to_balanced_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree green = new Tree();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int n = array.Length;
            Node root = green.sortedArrayToBST(array, 0, n - 1);
            Console.WriteLine("Preorder traversal of constructed BST");
            green.preorderedBST(root);

            Console.Read();
        }
    }
}

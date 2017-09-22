using System;

namespace single_node_deletion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList newList = new LinkedList(24);
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);
            newList.Add(5);
            newList.Add(6);
            newList.Add(7);
            newList.Add(8);
            newList.Add(9);

            newList.PrintNodes();
            newList.SinglyDeleteNode(3);
            newList.PrintNodes();
            Console.Read();
        }

        //private static void SinglyDeleteNode()
        //{
        //    Console.WriteLine("This works!");
        //    //throw new NotImplementedException();
        //}
    }
}

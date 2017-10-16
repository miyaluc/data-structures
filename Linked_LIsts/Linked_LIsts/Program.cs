using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList newList = new LinkedList();
            newList.PrintAllNodes();
            Console.WriteLine("");

            newList.AddAtLast("1stnode");
            newlist.AddAtLast("2ndnode");
            newlist.AddAtLast("3rdnode");
            newlist.AddAtLast("4thnode");
            newlist.PrintAllNodes();
            Console.WriteLine();

            Console.Read();
        }
    }
}

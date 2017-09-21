using System;

namespace nth_element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList newList = new LinkedList(24);
            newList.Add(13);
            newList.Add(15);
            newList.Add(9);
            newList.Add(8);
            newList.Add(28);
            newList.Add(72);
            newList.Add(45);
            newList.Add(3);
            newList.Add(12);

            newList.PrintMiddle();

            newList.NthFromEnd(4);
            Console.Read();
        }
    }
}

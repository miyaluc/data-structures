using System;

namespace sorted_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is a sorted stack:");
            Stack stacky = new Stack(0);

            stacky.Push(7);
            stacky.Push(2);
            stacky.Push(5);
            stacky.Push(3);
            stacky.Push(8);

            stacky.Print();
            Console.Read();
        }
    }
}

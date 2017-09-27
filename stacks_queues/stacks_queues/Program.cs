using System;

namespace stacks_queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stack money = new Stack(10);
            money.Push(3);
            money.Push(1);
            money.Push(2);
            money.PrintNodes();

            Queue people = new Queue(2);
            people.Enqueue(1);
            people.Enqueue(3);
            people.Enqueue(4);
            people.PrintNodes();

            Console.Read();
        }

    }
}

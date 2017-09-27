using System;

namespace stacks_queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stack money = new Stack(24);
            money.Push(6);
            money.Push(4);
            money.Push(1);

            money.PrintNodes();

            money.Pop();
            money.PrintNodes();


            Queue people = new Queue(24);
            people.Enqueue(6);
            people.Enqueue(4);
            people.Enqueue(1);

            people.PrintNodes();

            people.Dequeue();
            people.PrintNodes();


            Console.Read();
        }

    }
}

using System;

namespace fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Fibonacci FibFab = new Fibonacci();

            Console.WriteLine("Enter a number.");
            int fibfab = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<fibfab; i++)
            {
                Console.WriteLine("{0} ", fibonacci_sequence(i));
            }

            Console.Read();
        }
    }

}

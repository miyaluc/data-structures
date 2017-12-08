using System;

namespace Fibonacci_in_detail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Below is the Fibonacci sequence using a for loop.");
            Fibonacci_Iterative(15);
            Console.WriteLine("Below is the Fibonacci sequence using a while loop.");
            Fibonacci_While_Loop(9);
            Console.Read();
        }

        public static void Fibonacci_Iterative(int n)
        {
            //declare 3 int variables
            //int z will be the sum variable
            int x = 0, y = 1, z = 0;
            Console.WriteLine($"1: {x}");
            Console.WriteLine($"2: {y}");

            //this for loop begins at 3 because n(1) is always 0 and n(2) is always 1
            //n(3) will be the sume of 1 and 2
            for (int i = 3; i < n; i++)
            {
                //z equals the sum of x + y
                z = x + y;
                //output each value  until n is reached in for loop
                Console.WriteLine($"{i}: {z}");
                //x equals y
                x = y;
                //y equals z
                y = z;
            }
        }

        public static void Fibonacci_While_Loop(int n)
        {
            //declare 4 int variables
            //int sum will add x and y
            int x = 0, y = 1, tracker = 1, sum = 0;

            //this while loop will run as long as tracker is less than user input n
            while (tracker < n)
            {
                //giving sum a new value
                sum = x + y;
                //output n: sum
                Console.WriteLine($"{tracker}: {sum}");
                //x now equals y
                x = y;
                //y now equals sum
                y = sum;
                //incrementing tracker for while loop
                tracker++;
            }
        }

    }
}

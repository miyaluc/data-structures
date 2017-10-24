using System;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertionArraySort watchThis = new InsertionArraySort(new int[] { 12, 36, 3, 42, 81, 69, 27 });

            Console.WriteLine("Here is your array and it's really out of order. Let's get it sorted!");
            Console.WriteLine();
            foreach (int x in watchThis.arr)
            {
                Console.Write($" {x} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Look what we've accomplished with this messy array. That's insertion sorting for you.");
            Console.WriteLine();
            foreach(int x in watchThis.InsertionSort())
            {
                Console.Write($" {x} ");
            }

            Console.Read();                        
        }

    }
    
}


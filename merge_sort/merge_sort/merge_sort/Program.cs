using System;

namespace merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Merge_Sort[] group = new Merge_Sort[] {23, 43, 54,  12, 6, 89, 38 };
            group.Merge();
            group.DivideDrop();

            Console.Read();
        }
    }
}

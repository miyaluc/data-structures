using System;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            InsertionSort();
            Console.ReadLine();

            foreach (int x in arr)
            {

            }

        }
        public static int InsertionSort()
        {
            int[] arr = new int[] { 12, 36, 3, 42, 81, 69, 27 };
            Console.WriteLine($"Here is your array and it's really out of order: {arr}. Let's fix it!");

            int i;
            int k;

            for (i = 0; i < arr.Length-1; i++)
            {
                for (k=i+1; k>0; k--)
                {
                    if (arr[k] < arr[k-1])
                    {
                        int temp = arr[k - 1];
                        arr[k - 1] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
            Console.WriteLine($"Look what we've accomplished with this messy array: {arr}. That's insertion sorting for you.");
            return 0;
        }
    }
}

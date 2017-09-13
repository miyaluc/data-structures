using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to be reversed.");
            string input = Console.ReadLine();
            Console.WriteLine(ReverseIt(input));
            Console.Read();
        }

        static string ReverseIt(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
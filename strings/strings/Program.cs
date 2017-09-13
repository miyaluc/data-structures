using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word or series of words you'd like reversed.");
            string reversal = Console.ReadLine();
            //string input = Console.ReadLine();
            //Console.WriteLine(ReverseIt(input));
            //Console.Read();

            string meow = "";
            for (int i=reversal.Length - 1; i>=0; i--)
            {
                meow += reversal[i];
            }
            Console.WriteLine(meow);
            Console.Read();
        }
    }
}
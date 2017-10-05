using System;

namespace palindrome_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList test = new LinkedList();
            string word = "tacocat";

            test.Converter(word);

            test.Print();
            Console.WriteLine($"\n {test.Check()}");

            LinkedList test2 = new LinkedList();
            string word2 = "hello";

            test2.Converter(word2);
            Console.WriteLine();
            test2.Print();
            Console.WriteLine($"\n {test2.Check()}");

            Console.Read();
        }
    }
}

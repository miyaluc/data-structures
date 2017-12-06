using System;

namespace string_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IsPalindrome();

            NumberOfOccurences();

            Console.Read();
        }

        static bool IsPalindrome()
        {
            //declare string x
            string x = "racecar";

            //declare string y which will be empty
            string y = "";

            //implement for loop that decrements through the length of string x
            for (int i = x.Length - 1; i >= 0; i--)
            {
                //add each index of string x to string y
                y += x[i];
            }

            //compare string x to string y

            //make sure they are lower case

            //if string x and string y match
            if (x.ToLower() == y.ToLower())
            {
                //output "It's a palindrome"
                Console.WriteLine($"{x} is a palindrome");
                //return true
                return true;
            }
            //else output "It's not a palindrome"
            else
            {
                Console.WriteLine($"{x} is not a palindrome");

                //return false
                return false;
            }
        }

        static void NumberOfOccurences()
        {
            //declare and initialize array x
            int[] x = new int[] { 4, 4, 5, 5, 5, 7, 8, 10, 10, 10 };

            //declare temp array y that is set to x[0]
            int y = x[0];

            //declare int occurrence, set to 0
            int occurrence = 0;

            //implement for loop using x.Length as the max
            for (int i = 0; i < x.Length; i++)
            {
                //---if y is equal to x[i]
                if (y == x[i])
                {
                    //------increment occurrence
                    occurrence++;
                }
                else
                {
                    //------output number of occurences per number in array
                    Console.WriteLine($"{y}: {occurrence}");

                    //------y equals x[i]
                    y = x[i];

                    //------occurrence equals 1
                    occurrence = 1;

                }
                //---if i equals x.Length minus 1
                //    if (int i = x.Length - 1)
                //    {
                //     // ;
                //     }   

                //------increment occurrence

            }
        }




    }
}


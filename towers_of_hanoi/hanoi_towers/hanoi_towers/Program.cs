using System;
using System.Collections;

namespace hanoi_towers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of disks.");
            int disks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"For {disks} disks, make the following moves:");
            HanoiTowers(disks, 1, 3);
            int moves = Convert.ToInt32(Math.Pow(2, disks) - 1);
            Console.WriteLine($"This took {moves} moves.");

            Console.Read();
        }

        public void HanoiTowers(int n, int fromStack, int toStack)
        {
            int helpStack;

            if(n == 1)
            {
                Console.WriteLine($"{fromStack} -> {toStack}");
            } else
            {
                helpStack = 6 - (fromStack + toStack);

                HanoiTowers(n - 1, fromStack, helpStack);

                Console.WriteLine($"{fromStack} -> {toStack}");

                HanoiTowers(n - 1, helpStack, toStack);
            }
        }
    }
}

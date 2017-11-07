using System;
using System.Collections;

namespace hanoi_towers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void HanoiTowers(int n)
        {
            Stack Left = new Stack();
            Stack Mid = new Stack();
            Stack Right = new Stack();

            while (Left != null || Mid != null)
            {
                if(Left != null)
                {
                    if (Left.Peek. < Right.Peek && )
                    { Mid.Push(Left.Pop); }
                }
                else
                {

                }
            }
        }
    }
}

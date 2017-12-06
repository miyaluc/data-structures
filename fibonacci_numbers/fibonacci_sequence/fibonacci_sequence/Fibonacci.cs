using System;
using System.Collections.Generic;
using System.Text;

namespace fibonacci_sequence
{
    class Fibonacci
    {
        public void Fibby(int n)
        {
            //if n is less than or equal to 1
            if (n <= 1)
            {
                //if n is 0 return 0; if n is 1 return 1
                return n;
            }
            //otherwise return recursive call
            //the Fibonacci formula is Xn = Xn-1 + Xn-2
            return Fibby(n - 1) + Fibby(n - 2);
        }
    }
}

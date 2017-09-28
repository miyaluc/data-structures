using System;
using System.Collections.Generic;
using System.Text;

namespace palindrome_test
{
    class LinkedList
    {
        Node Head;
        Node Tail;

        void AddChar(char letter)
        {

        }
        public bool IsPalindrome()
        {
            if(Head == null)
            {
                throw new Exception("Check your entry. Letters only.");
            }
            runnerForward = Head;
            runnerBack = Tail;
            while(runnerForward.value == runnerBack.value)
            {
                runnerForward = runnerForward.Next;
                runnerBack = runnerBack.Previous;

                if(runnerForward.Next == runnerBack || runnerForward == runnerBack.Previous)
                {
                    return true;
                }
            }
        }
        
    }
}

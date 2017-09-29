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
            Node Forward = Head;
            Node Backward = Tail;

            while(Forward.Data == Backward.Data)
            {
                Forward = Forward.Next;
                Backward = Backward.Previous;

                if(Forward.Next == Backward || Forward.Next == Backward.Previous)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}

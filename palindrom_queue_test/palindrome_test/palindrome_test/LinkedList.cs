using System;
using System.Collections.Generic;
using System.Text;

namespace palindrome_test
{
    class LinkedList
    {
        Node Head;
        Node Tail;
        public Node curr;
        public int count = 0;
        public int midCount;

        public void AddChar(char letter)
        {
            Node newNode = new Node(letter);
            newNode.Data = letter;
            curr.Next = newNode;
            curr = newNode;
            count++;
            if (count % 2 == 1)
            {
                midCount++;
            }
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

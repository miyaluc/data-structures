using System;
using System.Collections.Generic;
using System.Text;

namespace making_acronyms
{
    class Acronym_Maker
    {
        public string ReturnAcronym(string input)
        {
            string[] forbiddenWord = new string[] { "a", "for", "and", "the", "with", "an", "or", "to", "of" };
            string acro = "";
            bool isForbiddenWord = false;
            string[] array = input.Split(' ');

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < forbiddenWord.Length; j++)
                {
                    if (array[i] == forbiddenWord[j])
                    {
                        isForbiddenWord = true;
                    }
                    else
                    {
                        isForbiddenWord = false;
                    }
                }

                if (!isForbiddenWord)
                {
                    acro += array[i][0];
                }
            }
            Console.WriteLine(acro);
            return acro;
        }
    }
}

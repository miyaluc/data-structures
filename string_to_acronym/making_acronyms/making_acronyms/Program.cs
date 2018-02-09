using System;

namespace making_acronyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Acronym_Maker silly = new Acronym_Maker();

            silly.ReturnAcronym("Federal Bureau of Investigations");
            silly.ReturnAcronym("Social Security Number");
            silly.ReturnAcronym("Raiders of the Lost Ark");
            silly.ReturnAcronym("Moms in the Mud");

            Console.Read();
        }
    }
}

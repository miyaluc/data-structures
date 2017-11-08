using System;

namespace CatsAndDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AdoptionCenter lineup = new AdoptionCenter();
            lineup.EnqueueAnimal("cat");
            lineup.EnqueueAnimal("dog");
            lineup.EnqueueAnimal("cat");
            lineup.EnqueueAnimal("cat");
            lineup.EnqueueAnimal("cat");
            lineup.EnqueueAnimal("dog");
            lineup.EnqueueAnimal("dog");
            lineup.EnqueueAnimal("cat");

            foreach(string animal in lineup)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();

            Console.Read();
        }
    }
}

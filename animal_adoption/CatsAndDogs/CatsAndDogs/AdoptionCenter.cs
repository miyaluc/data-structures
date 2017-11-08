using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogs
{
    class AdoptionCenter
    {
        public Queue<Animal> Dogs
        {
            get; set;
        }

        public Queue<Animal> Cats
        {
            get; set;
        }

        public int LinePosition
        {
            get; set;
        }

        public AdoptionCenter()
        {
            LinePosition = 0;
            Dogs = new Queue<Animal>();
            Cats = new Queue<Animal>();
        }

        public void EnqueueAnimal(string type)
        {
            if (type == "cat".ToLower())
            {
                Cats.Enqueue(new Animal
                {
                    Species = type,
                    IntakeNumber = LinePosition
                });
                LinePosition++;
            }
            else if (type == "dog".ToLower())
            {
                Cats.Enqueue(new Animal
                {
                    Species = type,
                    IntakeNumber = LinePosition
                });
                LinePosition++;
            }
        }

        public void DequeueCat()
        {
            Cats.Dequeue();
        }

        public void DequeueDog()
        {
            Dogs.Dequeue();
        }

        public void DequeueAny()
        {
            if(Dogs.Peek().IntakeNumber > Cats.Peek().IntakeNumber)
            {
                Cats.Dequeue();
            }
            else
            {
                Dogs.Dequeue();
            }
        }
    }
}

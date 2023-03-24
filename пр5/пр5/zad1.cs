using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр5
{
    interface IAnimal
    {
        void Voice();
    }

    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Гав!");
        }
    }

    class Cat : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу!");
        }
    }

    class Owl : IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }

        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("Тисе, я спю!");
            }
            else
            {
                Console.WriteLine("Ух! Ух! Ух!");
            }
        }
    }

    class Fox : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("yow-wow-wow");
        }
    }

    class Rooster : IAnimal
    {
        public void Voice()
        {
            bool animalIsFree = true;
            if (animalIsFree)
            {
                Console.WriteLine("Ку-ка-ре-ку");
            }
            else
            {
                Console.WriteLine("...");
            }
        }
    }

    class Program
    {
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("она говорит:");
            animal.Voice();
        }

        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Owl());
            myAnimals.Add(new Fox());
            myAnimals.Add(new Rooster());

            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }

            Console.ReadKey(true);
        }
    }
}

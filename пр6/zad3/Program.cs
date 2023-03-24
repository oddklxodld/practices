using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Human
    {
        public string Name
        {
            get;
            private set;
        }

        public int Age
        {
            get;
            private set;
        }

        public char Gender
        {
            get;
            private set;
        }

        public Human(string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
    class Worker : Human
    {
        public string Position
        {
            get;
            private set;
        }

        public Worker(string name, int age, char gender, string position) : base(name, age, gender)
        {
            Position = position;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human Mark = new Human("Марк Макарович", 56, 'М');
            Console.WriteLine(Mark.Name);
            Worker Eniseniya = new Worker("Енисения Сергеевна", 21, 'Ж', "инженер");
            Console.WriteLine(Eniseniya.Position);
            Console.ReadKey(true);
        }
    }
}

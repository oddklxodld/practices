using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Transport
    {
        public string Name
        {
            get;
            private set;
        }

        public int MaxSpeed
        {
            get;
            private set;
        }

        public Transport(string name, int speed)
        {
            Name = name;
            MaxSpeed = speed;
        }
    }

    class PolytechMachina: Transport
    {
        public void Music()
        {
            Console.WriteLine("Вы включили на полную громкость плохую музыку");
        }
        public PolytechMachina(string name, int speed) : base(name, speed)
        {
        }
    }

    class Samolet : Transport
    {
        public void PollinateField()
        {
            Console.WriteLine("Поле опылили");
        }
        public Samolet(string name, int speed) : base(name, speed)
        {
        }
    }

    class Meshalka : Transport
    {
        public void MixConcrete()
        {
            Console.WriteLine("Бетономешалка");
        }
        public Meshalka(string name, int speed) : base(name, speed)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transport Car = new Transport("Жигули", 350);
            PolytechMachina Polytech = new PolytechMachina("Пятак", 150);
            Polytech.Music();

            Samolet An = new Samolet("Ан-140Т", 956);
            An.PollinateField();

            Meshalka beton = new Meshalka("DENZEL", 250);
            beton.MixConcrete();

            Console.ReadKey(true);
        }
    }
}

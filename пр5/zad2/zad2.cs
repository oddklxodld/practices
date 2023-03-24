using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    interface IHello
    {
        void SayHello();
    }

    class English : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }

    class Spanish : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hola");
        }
    }

    class Arab : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("مرحبًا!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new English());
            greetings.Add(new Spanish());
            greetings.Add(new Arab());
            foreach (IHello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Posilka
    {
        public string Opisanie
        {
            get;
            private set;
        }

        public int Ves
        {
            get;
            private set;
        }
        public Posilka(string opisanie, int ves)
        {
            Opisanie = opisanie;
            Ves = ves;
        }
    }

    class ServisOtpravki
    {
        private static int LimitVes;
        private const int Limit = 10;

        public void Pochta(Posilka posilka)
        {
            LimitVes += posilka.Ves;
            if (LimitVes >= Limit)
            {
                Console.WriteLine("Ошибка! Вес отправленных посылок превысил лимит, отправка прервана.");
            }
            else
            {
                Console.WriteLine("{0} весом {1} кг успешно отправлена.", posilka.Opisanie, posilka.Ves);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ServisOtpravki servisotpravki = new ServisOtpravki();
            Console.ReadKey(true);
        }
    }
}

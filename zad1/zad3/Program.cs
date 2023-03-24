using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Ork
    {
        private static int zoloto;

        public static int kolvo_perenos_zolota
        {
            get;
            private set;
        }

        public int perenos_zolota
        {
            get;
            private set;
        }

        public Ork()
        {
            zoloto++;
            kolvo_perenos_zolota += 2;
            if (zoloto > 5)
            {
                perenos_zolota += 2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ork ork1 = new Ork();
            Console.WriteLine(Ork.kolvo_perenos_zolota);
            Ork ork2 = new Ork();
            Ork ork3 = new Ork();
            Console.WriteLine(Ork.kolvo_perenos_zolota);
            Ork ork4 = new Ork();
            Ork ork5 = new Ork();
            Ork ork6 = new Ork();
            Console.WriteLine(ork6.perenos_zolota);
            Console.ReadKey(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
   class chislo
    {
        private int n = 0;

        public int chislo0(int n)
        {
            this.n = 1;
            return n;
        }

        private bool SetNumber(int number)
        {
            if (number == this.n + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            chislo num = new chislo();
            int n;
            for (int i = 1; i >= 0; i = num.chislo0(n) + 1)
            {
                Console.WriteLine($"введите число {i}");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey(true);
        }
    }
}

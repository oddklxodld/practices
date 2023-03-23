using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class urav
    {
        public urav(double a, double b, double c, double d, double x1, double x2) {
            this.a = 1;
            this.b = 2;
            this.c = 3;
            this.d = 1;
            this.x1 = -1;
            this.x2 = -3;
        }

        private double a;
        private double b;
        private double c;
        private double d;
        private double x1;
        private double x2;

        private void dis(double a, double b, double c, double d)
        {
            d = Math.Pow(b, 2) - (4 * a * c);
            return;
        }
        public void CalculateRoots()
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return;
        }


        static void Main(string[] args)
        {
            double a, b, c,d,x1,x2;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());
// не совсем поняла почему тут ошибки, если переменные использовались выше
            urav myclass = new urav(a, b, c, d, x1, x2);
        }
    }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class cezar
    {
        static string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        static string Shifr(int k, string s, bool c)
        {
            string res = "";
            for(int i = 0; i<s.Length; i++)
            {
                int z = alf.IndexOf(s[i]);
                z += (c) ? k : -k;
                res += alf[z];
            }
            return res;
        }
        static void Main(string[] args)
        {
            string s = "";
            string c = Shifr(3, s, true);
            string r = Shifr(3, c, false);
            Console.WriteLine("{0}\n{1}", c, r);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class SmsMessage
    {
        private string text;
        private int maxdlina;
        private double nachstoimost;
        private double stoimost_1s;

        public string MessageText
        {
            get
            {
                return text;
            }
            set
            {
                text = NormalizeMessageText(value, maxdlina);
            }
        }

        public int MaxLength
        {
            get
            {
                return maxdlina;
            }
            set
            {
                maxdlina = value;
            }
        }

        public double nachStoimost
        {
            get
            {
                return nachstoimost;
            }
            set
            {
                nachstoimost = value;
            }
        }

        public double SymbolPrice
        {
            get
            {
                return stoimost_1s;
            }
            set
            {
                stoimost_1s = value;
            }
        }

        private double Price
        {
            get
            {
                return CalculatePrice(nachstoimost, stoimost_1s);
            }
        }
      
        public void Send()
        {

            Console.WriteLine($"было отправлено смс '{text}' длиной, {text.Length} кол-вом символов и стоимостью {Price} рублей");
        }

        private string NormalizeMessageText(string text, int length)
        {
            if (text.Length > length)
            {
                return text.Substring(0, text.Length - length);
            }
            return text;
        }

        private double CalculatePrice(double nachstoimost, double stoimost_1s)
        {
            if (text.Length < 65)
            {
                return nachstoimost;
            }
            else
            {
                int length = MessageText.Length - 65;
                return nachstoimost + length * stoimost_1s;
            }
        }
        public SmsMessage(string text, int dlina, double nachstoimost, double Stoimost_1s)
        {
            MessageText = text;
            MaxLength = dlina;
            nachStoimost = nachstoimost;
            Stoimost_1s = stoimost_1s;
        }

        static void Main(string[] args)
        {
            SmsMessage sms = new SmsMessage("СМС - реклама носит направленный характер и имеет минимальную степень уклоняемости", 82, 2, 0.7);
            sms.Send();
            Console.ReadKey(true);
        }
    }
}

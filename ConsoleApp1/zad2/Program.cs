using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class SmsMessage
    {
        private string text;

        public string MessageText
        {
            get
            {
                return text;
            }
            set
            {
                text = NormalizeMessageText(value);
            }
        }

        private double Price
        {
            get
            {
                return CalculatePrice();
            }
        }

        public SmsMessage(string text)
        {
            MessageText = text;
        }
        public void Send()
        {
            Console.WriteLine($"было отправлено смс '{text}' длиной, {text.Length} кол-вом символов и стоимостью {Price} рублей");
        }

        private string NormalizeMessageText(string text)
        {
            if (text.Length > 250)
            {
                return text.Substring(0, text.Length - 250);
            }
            return text;
        }

        private double CalculatePrice()
        {
            if (text.Length < 65)
            {
                return 1.5;
            }
            else
            {
                int length = MessageText.Length - 65;
                return 1.5 + length * 0.5;
            }
        }

        static void Main(string[] args)
        {
            SmsMessage sms = new SmsMessage("СМС-реклама носит направленный характер и имеет минимальную степень уклоняемости");
            sms.Send();
            Console.ReadKey(true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po
{
    internal class Program
    {
        class SMS
        {
            private string _smstext;
            public string smstext
            {
                get
                {
                    return _smstext;
                }
                private set
                {
                    _smstext = NormalizeMessageText(value);
                }
            }
            private double Price
            {
                get
                {
                    return CalculatePrice();
                }
            }
            public SMS(string text)
            {
                smstext = text;
            }
            public void SendMessage()
            {

                Console.WriteLine($"Сообщение '{_messagetext}'отправилось.");
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
                if (_smstext.Length < 65)
                {
                    return 1.5;
                } else
                {
                    int length = smstext.Length - 65;
                    return 1.5 + length * 0.5;
                }
            }
        }
        static void Main(string[] args)
        {
            SMS sms = new SMS("Списалась плата по тарифу-200 руб.");
            sms.SendMessage();
            Console.ReadKey(true);
        }
    }
}

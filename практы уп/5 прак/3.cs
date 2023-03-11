using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oooooooooooh
{
    interface IFilter
    {
        string Execute(string textLine);
    }
    class DigitFilter: IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            char[] symbols = {' ', ',', ':', ';', '-', '"', '(', ')', '.', '!', '?'};
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsLetter(textline[i]) || Array.IndexOf(symbols, textline[i]) >= 0)
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    class LetterFilter: IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsDigit(textline[i]))
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DigitFilter stringLetters = new DigitFilter();
            Console.WriteLine(stringLetters.Execute("ты найдешь потеряный рай88055."));
            LetterFilter stringDigits = new LetterFilter();
            Console.WriteLine(stringDigits.Execute("8дайт5е 6мн5е б4елы3е кр3ыл0ья, я у5то76па9ю в ому8те"));
            Console.ReadKey(true);
        }
    }
}
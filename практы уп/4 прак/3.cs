using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vladimirovna
{
    class yh
    {
        private static int Counter;
        public static int amountGold
        {
            get;
            private set;
        }
        public int Gold
        {
            get;
            private set;
        }
        public yh()
        {
            Counter++;
            Gold += 2;
            if (Counter > 5)
            {
                Gold += 2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            yh yh1 = new yh();
            Console.WriteLine(yh.amountGold);
            yh yh2 = new yh();
            yh yh3 = new yh();
            Console.WriteLine(yh.amountGold);
            yh yh4 = new yh();
            yh yh5 = new yh();
            yh yh6 = new yh();
            Console.WriteLine(yh6.Gold);
            Console.ReadKey(true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
class digit
    {
        private int n = 0;
        public int GetNumber(int digit)
        {
            if (SetNumber(digit))
            {
                this.n = digit;
            } else
            {
                this.n = 0;
            }
            return this.n;
        }
        private bool SetNumber (int digit)
        {
            if (digit == this.n + 1)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            digit num = new digit();
            int digit;
            for (int i = 1; i >= 0; i = num.GetNumber(digit)+1)
            {
                Console.WriteLine($"Введите число {i}");
                digit = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey(true);
        }
    }
}
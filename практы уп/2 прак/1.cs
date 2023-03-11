using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Kvadrat
    {
        private double a;
        private double b;
        private double c;
        private double x1;
        private double x2;
        private double D;
        public Kvadrat(double a, double b, double c)
        {
            this.a=a;
            this.b=b;
            this.c=c;
        }


        private double CalculateDiscriminant()
        {
            D = Math.Pow (b,2) - 4*a*c;
            return D;

        }
        private void CalculateRoots()
        {
            CalculateDiscriminant();
            if (D == 0)
            {
                x1 = -b / 2 * a;
                Console.WriteLine("x1 = {0}", x1);
            }

            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine ("x2 = {0}", x2);
            }
            else
            {
                Console.WriteLine("Корней нет!");
            }
        }
        public void QWER()
        {
            CalculateRoots();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Kvadrat a = new Kvadrat(4, -20, 25);
            a.QWER();
            Console.ReadKey(true);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ульяночка
{
    interface IHello
    {
        void SayHello();
    }
    class Russian: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class English: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class Spanish: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hola");
        }
    }
    class French: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Bonjour");
        }
    }
    class Italy: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Salut");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new Russian());
            greetings.Add(new English());
            greetings.Add(new Spanish());
            greetings.Add(new French());
            greetings.Add(new Italy());
            foreach (IHello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}
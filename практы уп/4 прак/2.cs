using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngkrhhhhhnuvhnuht
{
    class Package
    {
        public string Description
        {
            get;
            private set;
        }
        public int Weight
        {
            get;
            private set;
        }
        public Package(string description, int weight)
        {
            Description = description;
            Weight = weight;
        }
    }
    class SendingService
    {
        private static int LimitWeight;
        private const int Limit = 10;
        public void SendPackage(Package package)
        {
            LimitWeight += package.Weight;
            if (LimitWeight >= Limit)
            {
                Console.WriteLine("Внимание!!! Тяжелый вес.");
            }
            else
            {
                Console.WriteLine("Посылка {0} весом {1} кг отправлена успешно.", package.Description, package.Weight);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Package package_1 = new Package("Легкая посылка №1", 2);
            Package package_2 = new Package("Тяжелая посылка №2", 9);
            SendingService sendingService = new SendingService();
            sendingService.SendPackage(package_1);
            sendingService.SendPackage(package_2);
            Console.ReadKey(true);
        }
    }
}

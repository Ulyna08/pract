using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gttgggtttgtttttggtttgtttg
{
    class Human
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public Human (string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
    class Worker : Human
    {
        public string Position
        {
            get;
            set;
        }
        public Worker (string name, int age, char gender, string position) : base (name, age, gender)
        {

            Position = position;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human Nikita = new Human("������ �������", 38, '�', '��������');
            Console.WriteLine(Nikita.Name);
            Worker Ulyana = new Worker("������ ��������", 28, '�', "����������");
            Console.WriteLine(Ulyana.Position);
            Console.ReadKey(true);
        }
    }
}
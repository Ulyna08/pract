using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZAAAAAAALLLLLLLL
{
    class Animal
    {
        private string Name
        {
            get;
            set;
        }
        private int Age
        {
            get;
            set;
        }
        private int Legs
        {
            get;
            set;
        }
        private string Species
        {
            get;
            set;
        }
        private string Status
        {
            get;
            set;
        }
        public void Introduce()
        {
            Console.WriteLine($"������, ��� ��� {Name} � ��� {Age} ���.");
        }
        public Animal (string name, int age, int legs, string species, string status)
        {
            Name = name;
            Age = age;
            Legs = legs;
            Species = species;
            Status = status;
        }
    }
    class AB : Animal
    {
        public AB (string name, int age, int legs, string species, string status) : base (name, age, legs, species, status)
        {
            legs = 0;
            species = "���������";
        }
    }
    class Cats : Animal
    {
        public void Voice()
        {
            Console.WriteLine("��� ���!");
        }
        public Cats (string name, int age, int legs, string species, string status) : base (name, age, legs, species, status)
        {
            legs = 4;
            species = "����";
        }
    }
    class Dogs: Animal
    {
        private string Master;
        public void GreetMaster()
        {
            Console.WriteLine($"������, {Master}!");
        }
        public Dogs (string name, int age, int legs, string species, string status, string master) : base (name, age, legs, species, status)
        {
            legs = 4;
            species = "������";
            Master = master;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("����������� ����� �������� �� ���������� ���, �������, ���������� ���, ���, �������. ������� 3 ���������� ������ ��������: ���������, ����� � ������. ��� ���� ����������� �������� ����� ������.");
            Animal Zebra = new Animal("�����", 2, 4, "�������������", "������");
            Zebra.Introduce();
            Cat bycha = new bycha("�������", 11, 4, "�������������", "������");
            bycha.Introduce();
            bycha.Voice();
            Dog roza = new roza("����", 8, 4, "�������������", "������");
            roza.GreetMaster();
            Console.ReadKey(true);
        }
    }
}
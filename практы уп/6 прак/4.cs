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
            Console.WriteLine($"Привет, мое имя {Name} и мне {Age} лет.");
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
            species = "динозавры";
        }
    }
    class Cats : Animal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу мяу!");
        }
        public Cats (string name, int age, int legs, string species, string status) : base (name, age, legs, species, status)
        {
            legs = 4;
            species = "коты";
        }
    }
    class Dogs: Animal
    {
        private string Master;
        public void GreetMaster()
        {
            Console.WriteLine($"Привет, {Master}!");
        }
        public Dogs (string name, int age, int legs, string species, string status, string master) : base (name, age, legs, species, status)
        {
            legs = 4;
            species = "собаки";
            Master = master;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Реализовать класс Животные со свойствами Имя, Возраст, Количество ног, Вид, Занятие. Создать 3 наследника класса Животное: Динозавры, Кошки и Собаки. Для двух наследников добавить новые методы.");
            Animal Zebra = new Animal("зебра", 2, 4, "млекопитающие", "рожает");
            Zebra.Introduce();
            Cat bycha = new bycha("Бусинка", 11, 4, "млекопитающие", "играет");
            bycha.Introduce();
            bycha.Voice();
            Dog roza = new roza("Роза", 8, 4, "млекопитающие", "моется");
            roza.GreetMaster();
            Console.ReadKey(true);
        }
    }
}
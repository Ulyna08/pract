using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wsdcvfgbhnkkpplpoki
{
    interface IAnimal
    {
        void Voice();
    }
    class Dog: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("���!");
        }
    }
    class Cat: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("���!");
        }
    }
    class Owl: IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("����, � ���!");
            }
        }
    }
    class Pig: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("���!");
        }
    }
    class Bear : IAnimal
    {
        public void Voice()
        {
            bool animalIsFree = true;
            if (animalIsFree)
            {
                Console.WriteLine("�����!");
            }
        }
    }
    internal class Program
    {
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("�� ������ �����, � �� � �����:");
            animal.Voice();
        }
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Owl());
            myAnimals.Add(new Pig());
            myAnimals.Add(new Bear());
            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }
            Console.ReadKey(true);
        }
    }
}

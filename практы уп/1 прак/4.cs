using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Car
    {
        public string name;
        public double maxSpeed;
        private double time1;
        public double time
        {
            get
            {
                return time1;
            }
            set
            {
                time1 = CalculateTime(value);
            }
        }
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        public void InfaCar()
        {
            Console.WriteLine($"Название автомобиля: {name}, максимальная скрость: {maxSpeed}.");
        }
        public Car()
        {
            this.name = "Авто";
            this.maxSpeed = 220;
            this.time = 0;
        }
        public Car(string name, double speed, double time)
        {
            this.name = name;
            this.maxSpeed = speed;
            this.time = time;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[4];
            double distance = 800;
            Car BMW = new Car("BMW", 280, distance);
            cars[0] = BMW;
            Car toyota = new Car("Toyota", 310, distance);
            cars[1] = toyota;
            Car ford = new Car("Ford", 370, distance);
            cars[2] = ford;
            Car bugatti = new Car("Bugatti", 400, distance);
            cars[3] = bugatti;
            double[] DOO = new double[4];
            for (int i = 0; i < cars.Length; i++)
            {
                DOO[i] = cars[i].time;
            }
            Array.Sort(DOO);
            for (int i = 0; i < DOO.Length; i++)
            {
                for (int j = 0; j < cars.Length; j++)
                {
                    if (DOO[i] == cars[j].time)
                    {
                        Console.WriteLine($"{i+1} место занимает автомобиль {cars[j].name} с максимальной скоростью {cars[j].maxSpeed}, преодолев {distance} км за {Math.Round(cars[j].time, 2)} ч.");
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}
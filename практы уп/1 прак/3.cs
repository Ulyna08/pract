﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car
    {
        public double maxSpeed;
        public string Name;

        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;

        }
        public void WhiteRabbit()
        {
            Console.WriteLine(maxSpeed);
            Console.WriteLine(Name);

        }

        public Car(double speed, string Name)
        {
            this.maxSpeed = speed;
            this.Name = Name;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car rabbit = new Car(140, "LADA PRIORA");
            rabbit.WhiteRabbit();
            Console.ReadKey(true);
        }
    }
}

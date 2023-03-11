using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ннггммммммм
{
    class mobila
    {
        public mobila (string model, string number)
        {
            Model = model;
            Number = number;
        }
        public string Model
        {
            get;
            set;
        }
        public string Number
        {
            get;
            set;
        }
        public void Call(string number)
        {
            Console.WriteLine($"Вызов по номеру моб. телефона{number}");
            WriteToLog($"Вызов {number}");
        }
        protected void WriteToLog(string text)
        {
            File.AppendAllText("log.txt", $"{Model}, {DateTime.Now}: {text}\n");
        }
    }
    class Smartphone : mo
    {
        public Smartphone (string model, string number, double cameraResolution) : base (model, number)
        {
            CameraResolution = cameraResolution;
        }
        public double CameraResolution
        {
            get;
            set;
        }
        public void Shoot()
        {
            Console.WriteLine("Снимок сделан");
            WriteToLog($"Снимок сделан");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone myHomePhone = new Phone("Sumsung", "89087801129");
            myHomePhone.Call("87853450987");
            Smartphone myWorkPhone = new Smartphone("iPhone 11", "89056785888", 80.5);
            myWorkPhone.Call("112");
            myWorkPhone.Shoot();
            Console.ReadKey(true);
        }
    }
}

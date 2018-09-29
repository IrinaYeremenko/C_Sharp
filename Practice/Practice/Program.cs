using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Auto
    {
        private string name;
        private double speed;

        public Auto(string name, double speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public double Speed
        {
            get { return speed; }

            set
            {
                if (value > 0)
                    speed = value;
                else Console.WriteLine("Скорость автомобиля не может быть меньше 0!");
            }
        }

        public void AboutAuto()
        {
            if (speed > 0)
                Console.WriteLine("Представлен автомобиль марки {0}, который развивает скорость до {1}", name, speed);
            else Console.WriteLine("Скорость автомобиля не может быть меньше 0!");
        }
    }

    class SmallCar : Auto
    {
        public SmallCar(string name, double speed) : base(name, speed)
        {
            Console.WriteLine("Легковой автомобиль перевозит пассажиров");
        }
    }
    class BigCar : Auto
    {
        public BigCar(string name, double speed) : base(name, speed)
        {
            Console.WriteLine("Грузовой автомобиль перевозит грузы");
        }
    }
    class AddCar : Auto
    {
        public AddCar(string name, double speed) : base(name, speed)
        {
            Console.WriteLine("Тягач таскает прицеп");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Auto[] autos =
            {
                new SmallCar("BMW", 296.5),
                new BigCar("ЗИЛ", 188.3),
                new AddCar("КРАЗ", -1),
            };

            foreach (Auto a in autos)
            {
                a.AboutAuto();
            }

            double max = -1;
            string n = " ";

            foreach (Auto s in autos)
            {
                if (max < s.Speed)
                {
                    max = s.Speed;
                    n = s.Name;
                }
            }
            Console.WriteLine("Автомобиль, развивающий самую высокую скорость - {0}", n);
        }
    }
}
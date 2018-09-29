using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    abstract class Objects
    {
        public string Name { get; set; }
        public abstract void AboutMe();
    }

    interface IFlying
    {
        void MethodFly();
    }

    interface IFloating
    {
        void MethodFloat();
    }

    interface IRunning
    {
        void MethodRun();
    }

    interface IEngine
    {
        void MethodEngine();
    }

    class Plane : Objects, IFlying, IEngine
    {
        public Plane()
        {
            this.Name = "Самолёт";
        }
        public override void AboutMe()
        {
            Console.WriteLine("Первый объект - это {0}:", Name);
        }
        void IFlying.MethodFly()
        {
            Console.WriteLine("{0} может летать", Name);
        }
        void IEngine.MethodEngine()
        {
            Console.WriteLine("{0} имеет двигатель", Name);
        }
    }
    class Eagle : Objects, IFlying
    {
        public Eagle()
        {
            this.Name = "Орёл";
        }
        public override void AboutMe()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Второй объект - это {0}:", Name);
        }
        void IFlying.MethodFly()
        {
            Console.WriteLine("{0} умеет летать", Name);
        }
    }
    class Duck : Objects, IFloating, IRunning
    {
        public Duck()
        {
            this.Name = "Утка";
        }
        public override void AboutMe()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Третий объект - это {0}:", Name);
        }
        void IFloating.MethodFloat()
        {
            Console.WriteLine("{0} умеет плавать", Name);
        }
        void IRunning.MethodRun()
        {
            Console.WriteLine("{0} умеет бегать по земле", Name);
        }
    }
    class Hen : Objects, IRunning
    {
        public Hen()
        {
            this.Name = "Курица";
        }
        public override void AboutMe()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Четвёртый объект - это {0}:", Name);
        }
        void IRunning.MethodRun()
        {
            Console.WriteLine("{0} умеет бегать по земле", Name);
        }
    }
    class MotorBoat : Objects, IFloating, IEngine
    {
        public MotorBoat()
        {
            this.Name = "Моторная лодка";
        }
        public override void AboutMe()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Пятый объект - это {0}:", Name);
        }
        void IFloating.MethodFloat()
        {
            Console.WriteLine("{0} может плавать", Name);
        }
        void IEngine.MethodEngine()
        {
            Console.WriteLine("{0} имеет двигатель", Name);
        }
    }
    class Hare : Objects, IRunning
    {
        public Hare()
        {
            this.Name = "Заяц";
        }
        public override void AboutMe()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Шестой объект - это {0}:", Name);
        }
        void IRunning.MethodRun()
        {
            Console.WriteLine("{0} умеет бегать по земле", Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            plane.AboutMe();
            IEngine enginePlane = new Plane();
            enginePlane.MethodEngine();
            IFlying flyingPlane = new Plane();
            flyingPlane.MethodFly();

            Eagle eagle = new Eagle();
            eagle.AboutMe();
            IFlying flyingEagle = new Eagle();
            flyingEagle.MethodFly();

            Duck duck = new Duck();
            duck.AboutMe();
            IFloating floatingDuck = new Duck();
            floatingDuck.MethodFloat();
            IRunning runningDuck = new Duck();
            runningDuck.MethodRun();

            Hen hen = new Hen();
            hen.AboutMe();
            IRunning runningHen = new Hen();
            runningHen.MethodRun();

            MotorBoat motorBoat = new MotorBoat();
            motorBoat.AboutMe();
            IEngine engineBoat = new MotorBoat();
            engineBoat.MethodEngine();
            IFloating floatingBoat = new MotorBoat();
            floatingBoat.MethodFloat();

            Hare hare = new Hare();
            hare.AboutMe();
            IRunning runningHare = new Hare();
            runningHare.MethodRun();

            Console.WriteLine("____________________________");
            Console.WriteLine("Массив летающих объектов:");
            IFlying[] flying =
            {
                new Plane(),
                new Eagle()
            };
            foreach(IFlying fly in flying)
            {
                fly.MethodFly();             
            }
            Console.WriteLine(" ");
            Console.WriteLine("Массив плавающих объектов:");
            IFloating[] floating =
            {
                new Duck(),
                new MotorBoat()
            };
            foreach(IFloating flo in floating)
            {
                flo.MethodFloat();
            }
        }
    }
}

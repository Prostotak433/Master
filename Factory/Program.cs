using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Car toyota = factory.create("Toyota");
            Car Audi = factory.create("audi");


        }
    }
    interface Car
    {
        void drive();
    }
    class Toyota: Car
    {
        public void drive()
        {
            Console.Write("Drive a Toyota");
        }
    }
    class Audi: Car
    {
        public void drive()
        {
            Console.Write("drive a Audi");
        }
    }
    class Factory
    {
        public Car create(string typeOfCar)
        {
            switch (typeOfCar)
            {
                case "Toyota":return new Toyota();
                case "Audi":return new Audi();
                default: return null;
            }
        }

    }
}

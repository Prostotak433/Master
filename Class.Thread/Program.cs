using System;

namespace Class.Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car();
            bmw.Print();
            Car car = new Car();
            car.carName = "Vaz";
            car.carSpeed = 10;
            for (int i = 0; i < 10; i++)
            {
                car.SpeedUp(10);
                car.Print();
            }
            Console.ReadLine();
        }
    }        
    class Car
    {
        public string carName;
        public int carSpeed;
        public void Name(string carNameee)
        {
            this.carName = carNameee;
        }
        public Car()
        {
            carName = "BMW";
            carSpeed = 1;
        }
        public void Print()
        {
            Console.WriteLine("{0} have a speed {1}", carName, carSpeed);
        }
        public void SpeedUp(int delta) => carSpeed += delta;
    }
}
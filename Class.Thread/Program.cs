using System;

namespace Class.Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Car jetta = new Car();
            jetta.Color = "Red";
            jetta.Name = "Jetta";
            jetta.Speed = 180;
            jetta.Info();
            Garage garage = new Garage(jetta, 3);
            Console.WriteLine("{0}", garage.MyAuto.Name);
            Console.WriteLine("{0}", garage.NumberOfCars);
        }
    }
   
    class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public void Info()
        {
            Console.WriteLine("Name = {0}, Speed = {1}, Color = {2}", Name, Speed, Color);
        }
    }
    class Garage
    {
        public int NumberOfCars { get; set; } = 1;
        public Car MyAuto { get; set; } = new Car();
       
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}
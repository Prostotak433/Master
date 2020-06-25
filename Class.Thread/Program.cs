using System;

namespace Class.Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.TurnOnRadio(false);
            car.numberPage = 30_000_000;
            car.Name = "Serj";
            Console.WriteLine(car.Name);
        }
    }
    class Radio
    {
        public void Power(bool turnOn)
        {
            Console.WriteLine("Radio on {0}", turnOn);
        }
    }
    class Car
    {
        
        private string _name;
        private Radio myRadio = new Radio();
        public int numberPage;
        public string Name { get { return _name; } set { _name = value; } }
        public void TurnOnRadio(bool onOff)
        {
            myRadio.Power(onOff);
        }
    }
}
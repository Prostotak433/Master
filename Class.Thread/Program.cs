using System;

namespace Class.Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle c = new Motorcycle(5);
            c.driverName = "Tiny";
            Console.WriteLine("Rider name is {0}", c.driverName);
            Console.ReadLine();
        }
    }        
    class Motorcycle
    {
        public int driverIntesity;
        public string driverName;
        public Motorcycle()
        {
            Console.WriteLine("In default ctor");
        }
        public Motorcycle(int intesity) : this(intesity, " ")
        {
            Console.WriteLine("In ctor taking an int");
        }
        public Motorcycle(string name) : this(0, name)
        {
            Console.WriteLine("In ctor taking a string");
        }
        public Motorcycle(int intesity, string name)
        {
            Console.WriteLine("In master ctor");
            if(intesity > 10)
            {
                intesity = 10;
            }
            driverIntesity = intesity;
            driverName = name;
        }

    }
}
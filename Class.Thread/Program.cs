using System;

namespace Class.Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }        
    class Motorcycle
    {
        public int driverIntesity;
        public string driverName;
        public Motorcycle() { }
        public Motorcycle(int intesity) : this(intesity, " ") { }
        public Motorcycle(string name) : this(0, name) { }
        public Motorcycle(int intesity, string name)
        {
            if(intesity > 10)
            {
                intesity = 10;
            }
            driverIntesity = intesity;
            driverName = name;
        }

    }
}
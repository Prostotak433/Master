using System;

namespace Pattern_matching
{
    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("I work");
        }
    }
    class Manager:Employee
    {
        public override void Work()
        {
            Console.WriteLine("GO go GO Work");
        }
        public bool IsonVacation { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

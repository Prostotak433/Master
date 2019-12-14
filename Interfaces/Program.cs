using System;

namespace Interfaces
{
    interface Ispeed
    {
        private const int minSpeed = 0;
        static int maxSpeed = 70;
        public void Move()
        {
            Console.WriteLine("Move");
        }
        string Name { get; set; }
        delegate void Move(string mess);
        event Move MoveEvent;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ispeed.maxSpeed);
        }
    }
}

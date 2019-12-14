using System;

namespace Interfaces
{
    interface Ispeed
    {
        const int minSpeed = 0;
        static int maxSpeed = 70;
        void Move();
        string Name { get; set; }
        delegate void Move(string mess);
        event Move MoveEvent;

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

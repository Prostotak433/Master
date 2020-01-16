﻿using System;

namespace Interfaces
{
    public interface Ispeed
    {
        public const int minSpeed = 0;
        public int maxSpeed = 70;
        int MaxSpeed { get { return 0; } }
        public void Move()
        {
            Console.WriteLine("Move");
            Console.WriteLine("");
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
            Console.WriteLine(Ispeed.minSpeed);
            Console.ReadKey();
        }
    }
}

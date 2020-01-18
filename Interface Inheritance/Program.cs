using System;

namespace Interface_Inheritance
{
    interface IAction
    {
        void Move();
    }
    interface IRunAction:IAction
    {
        void Run();
    }
    class BaseAction:IRunAction
    {
        public void Move()
        {
            Console.WriteLine("Move");
        }
        public void Run()
        {
            Console.WriteLine("Run");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

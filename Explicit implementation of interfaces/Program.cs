using System;

namespace Explicit_implementation_of_interfaces
{
    interface IAction
    {
        void Move();
    }
    class BaseAction : IAction
    {
        void IAction.Move()
        {
            Console.WriteLine("Move in Base class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseAction action = new BaseAction();
            ((IAction)action).Move();
            IAction action2 = new BaseAction();
            action2.Move();
        }
    }
}

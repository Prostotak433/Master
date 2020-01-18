using System;

namespace Interface_implementation_in_base_and_derived_classes
{
    interface IAction
    {
        void Move();
    }
     class BaseAction : IAction
    {
        public  void Move()
        {
            Console.WriteLine("Base Action");
        }
    }
    class HeroAction : BaseAction, IAction
    {
        public new void Move()
        {
            Console.WriteLine("Hero Action");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseAction action1 = new BaseAction();
            action1.Move();
            BaseAction action2 = new HeroAction();
            action2.Move();
            IAction action3 = new BaseAction();
            action3.Move();
            IAction action4 = new HeroAction();
            action4.Move();
        }
    }
}

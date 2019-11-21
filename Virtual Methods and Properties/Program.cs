using System;

namespace Virtual_Methods_and_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} работает в {Company}");
        }
    }
}

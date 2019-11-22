using System;

namespace The_difference_between_overriding_and_hiding_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Employee("Tom", "Microsoft");
            tom.Display();      // Tom
        }
    }
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
                : base(name)
        {
            Company = company;
        }
        public new void Display()
        {
            Console.WriteLine($"{Name} работает в {Company}");
        }
    }
}

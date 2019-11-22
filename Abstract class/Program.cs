using System;

namespace Abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Tom", 500);
            Employee employee = new Employee("Bob", "Apple");
            client.Display();
            employee.Display();
        }
    }
    abstract class Person
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
    class Client : Person
    {
        public int Sum { get; set; }    // сумма на счету

        public Client(string name, int sum)
            : base(name)
        {
            Sum = sum;
        }
    }
    class Employee : Person
    {
        public string Position { get; set; } // должность

        public Employee(string name, string position)
            : base(name)
        {
            Position = position;
        }
    }
    class Base
    {
        public virtual void Display()
        {
            Console.WriteLine("This is Base");
        }
    }
    abstract class Derived : Base
    {
        public override void Display()
        {
            Console.WriteLine("This is Derived");
        }
    }
}



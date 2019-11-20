using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("bob");
            p.Display();
            Employee emp = new Employee ("non","WTF" );
            emp.Display();
            

        }
    }
    class Person
    {
        private string _name;
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
        public string Company;
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }
    sealed class Admin
    {

    }
}

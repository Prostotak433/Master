using System;
using System.Collections.Generic;

namespace Collection.Stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> numbers = new Stack<double>();
            numbers.Push(2.3);
            numbers.Push(3.6);
            numbers.Push(4.7);
            double stackElement = numbers.Pop();
            Console.WriteLine(stackElement);

            Stack<Person> people = new Stack<Person>();
            people.Push(new Person() { Name = "Tom", Age = 3 });
            people.Push(new Person() { Name = "Bob", Age = 4 });
            people.Push(new Person() { Name = "Sem", Age = 5 });

            foreach(Person p in people)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Age);
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

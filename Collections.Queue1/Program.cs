using System;
using System.Collections.Generic;

namespace Collections.Queue1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(3);
            numbers.Enqueue(5);
            numbers.Enqueue(8);
            int queueElement = numbers.Dequeue();
            int queueElement1 = numbers.Dequeue();
            Console.WriteLine(queueElement);
            Console.WriteLine(queueElement1);

            Queue<Person> people = new Queue<Person>();
            people.Enqueue(new Person() { Name = "Tom" });
            people.Enqueue(new Person() { Name = "Bob" });
            people.Enqueue(new Person() { Name = "Sem" });

            Person pp = people.Peek();
            Console.WriteLine(pp.Name);

            Console.WriteLine("Сейчас в очереди {0} человек", people.Count);

            foreach(Person p in people)
            {
                Console.WriteLine(p.Name);
            }
            Person person = people.Dequeue();
            Console.WriteLine(person.Name);
                
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Collection.LinkedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(1);
            numbers.AddFirst(2);
            numbers.AddAfter(numbers.Last, 3);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            LinkedList<Person> people = new LinkedList<Person>();
            LinkedListNode<Person> tom = people.AddLast(new Person() { Name = "Tom" });
            people.AddLast(new Person() { Name = "Bob" });
            people.AddFirst(new Person() { Name = "Den" });

            Console.WriteLine(tom.Previous.Value.Name);
            Console.WriteLine(tom.Next.Value.Name);
        }
    }
    class Person
    {
        public string Name { get; set; }
    }

}

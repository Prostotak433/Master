using System;
using System.Collections.Generic;

namespace Collection.LisT1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 13, 22, 4, 3, 101 };
            numbers.Add(2);
            numbers.AddRange(new int[] { 11, 33, 21 });
            numbers.Insert(0, 666);
            numbers.RemoveAt(1);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            List<Person> people = new List<Person>(3);
            people.Add(new Person() { Name = "Lexa" });
            people.Add(new Person() { Name = "Vlad" });
            foreach(Person p in people)
            {
                Console.WriteLine(p.Name);
            }
        }
        class Person
        {
            public string Name { get; set; }
        }
    }
}

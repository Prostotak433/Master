﻿using System;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people[0] = new Person { Name = "" };
            people[1] = new Person { Name = "Lexa" };
            Person tom = people[0];
            Console.WriteLine(tom?.Name);
            Console.ReadKey();
        }
    }
    class People
    {
        Person[] data;
        public People()
        {
            data = new Person[5];
        }
        public Person this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public Person this[string name]
        {
            get
            {
                Person person = null;
                foreach (var p in data)
                {
                    if (p?.Name == name)
                    {
                        person = p;
                        break;
                    }
                }
                return person;
            }
        }

    }
    class Person
    {
        public string Name { get; set; }
    }
}

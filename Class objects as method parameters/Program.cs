﻿using System;

namespace Class_objects_as_method_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { name = "Tom", age = 23 };
            ChangePerson(p);

            Console.WriteLine(p.name); // Alice
            Console.WriteLine(p.age); // 23

            Console.Read();
        }

        static void ChangePerson(Person person)
        {
            // сработает
            person.name = "Alice";
            // сработает только в рамках данного метода
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }
    }
    class Person
    {
        public string name;
        public int age;
    }
}

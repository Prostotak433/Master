using System;

namespace System.String1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Tom", Age = 23 };
            Console.WriteLine("Имя: {0}  Возраст: {1}", person.Name, person.Age);
            double number = 33.12;
            Console.WriteLine(number.ToString("C2"));
            Console.WriteLine(number.ToString("P1"));
            Console.WriteLine(number.ToString("d1"));
            Console.WriteLine(number.ToString("f4"));


        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

using System;

namespace Class
{
    class Person
    {
        public string Name;
        public int Age;
        public Person(string n, int a) { Name = n; Age = a}
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {n}  Возраст: {a}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 19;
            person.Name = "LLL";
            Console.WriteLine(person.Name);
                
        }
    }
}

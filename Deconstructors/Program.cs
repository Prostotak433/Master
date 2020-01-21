using System;

namespace Deconstructors
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Deconstruct(out string name, out int age)
        {
            name = this.Name;
            age = this.Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Age = 33, Name = "Tom" };
            (string name, int age) = person;
        }
    }
}

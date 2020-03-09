using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            User tom;
            tom.Age = 12;
            tom.Name = " TOM ";
            int x = tom.Age;
        }
        struct User
        {
            public string Name;
            public int Age;
            public void Display()
            {
                Console.WriteLine($"Name: {Name}  Age: {Age}");
            }
        }
    }
}
using System;

namespace Anonim_Type
{
    class User
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User tom = new User();
            int age = 34;
            var student = new { tom.Name, age };
            Console.WriteLine(student.Name);
            Console.WriteLine(student.age);

            var people[] = new[]
            {
                new{Name="bob"},
                new{Name="tom"}
            };
            Console.Read();
        }
    }
}

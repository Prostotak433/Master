using System;

namespace _10._Formatting_and_interpolating_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Age = 23, Name = "Tom" };
            Console.WriteLine("name {0} age{1}", person.Name, person.Age);
            long number = 380984122055;
            string result = number.ToString("{0:+# (###) ### ## ##}");
            Console.WriteLine(result);
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

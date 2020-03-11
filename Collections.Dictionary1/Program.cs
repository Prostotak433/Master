using System;
using System.Collections.Generic;

namespace Collections.Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countries = new Dictionary<int, string>(5);
            countries.Add(1, "Ukraine");
            countries.Add(3, "France");
            countries.Add(5, "Germani");
            countries.Add(2, "Spain");
            countries.Add(4, "Turkey");
            countries[3] = "USA";
            countries.Add(10, "Canada");
            countries.Remove(2);
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + "-" + keyValue.Value);
            }
            Dictionary<char, Person> people = new Dictionary<char, Person>();
            people.Add('a', new Person() { Name = "Tom" });
            people.Add('b', new Person() { Name = "Sem" });
            people.Add('c', new Person() { Name = "Bob" });
            people['d'] = new Person() { Name = "Serj" };
            foreach(KeyValuePair<char, Person> keyValye in people)
            {
                Console.WriteLine(keyValye.Key + "-" + keyValye.Value.Name);
            }
            foreach(char c in people.Keys)
            {
                Console.WriteLine(c);
            }
            foreach(Person p in people.Values)
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

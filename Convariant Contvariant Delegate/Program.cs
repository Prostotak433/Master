using System;

namespace Convariant_Contvariant_Delegate
{
    class Person
    {
        public string Name { get; set; }
    }
    class Client : Person { }
    class Program
    {
        delegate Person PersonFactory(string name);
        static void Main(string[] args)
        {
            PersonFactory personDel;
            personDel = BuildClient;
            Person p = personDel("Tom");

        }
        private static Client BuildClient(string name)
        {
            return new Client { Name = name };
        }
        private static Person GetPerson(string name)
        {
            return new Person { Name = name };
        }
        private static Client GetClient(string name)
        {
            return new Client { Name = name };
        }
    }
}

using System;

namespace System.Object
{
    class Program
    {
        private static void Main(string[] args)
        {

        }
    }
    class Person
    {
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}

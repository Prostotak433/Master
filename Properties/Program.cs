using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {

        }    
    }
    class Person
    {
        private int pluse = 15;
        private string name;
        public string Name
        {
            
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

}

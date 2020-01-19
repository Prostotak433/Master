using System;

namespace Copy_objects_Interface
{
    public interface ICloneable
    {
        object Clone();
    }
    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Work { get; set; }
        public object Clone()
        {
            Company company = new Company { Name = this.Work.Name };
            return new Person
            { Age = this.Age, Name = this.Name, Work = company };
        }
    }
    class Company
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Tom", Age = 32, Work=new Company { Name = "Micro" } };
            Person p2 = (Person)p1.Clone();
            p2.Name = "Bob";
            p2.Work.Name = "Zavod";
            Console.WriteLine(p1.Work.Name);
        }
    }
}

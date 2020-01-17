using System;

namespace Explicit_implementation_of_interfaces
{
    interface IUniversity
    {
        void Study();
    }
    
    interface ISchool
    {
        void Study();
    }
    class Person : IUniversity,ISchool
    {
        void IUniversity.Study()
        {
            Console.WriteLine("University");
        }
        void ISchool.Study()
        {
            Console.WriteLine("School");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            ((ISchool)person).Study();
            ((IUniversity)person).Study();
            Console.Read();
        }
    }
}

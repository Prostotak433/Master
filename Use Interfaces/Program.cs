using System;

namespace Use_Interfaces
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            Person person = new Person("Tom", 2000);
            person.Put(30);
            Console.WriteLine(person.CurrentSum);
            person.WintWithdraw(50);
            Console.WriteLine(person.CurrentSum);
            Console.Read();
        }
    }
}

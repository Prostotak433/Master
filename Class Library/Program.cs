using System;
using MyLib;

namespace Class_Library
   
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person { name = "Tom", age = 35 };
            Console.WriteLine(tom.name);
        }
    }
}

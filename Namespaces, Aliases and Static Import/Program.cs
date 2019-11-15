using System;
using Person = HelloApp.User;
using Printer = System.Console;
namespace Namespaces__Aliases_and_Static_Import
{
   HelloApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Person person = new Person();
                person.name = "Tom";
                Printer.WriteLine(person.name);
                Printer.Read();
            }
        }

        class User
        {
            public string name;
        }
    }

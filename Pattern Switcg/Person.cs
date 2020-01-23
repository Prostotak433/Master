using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Switcg
{

    class Person
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string Language { get; set; }
        static string GetMessage(Person p) => p switch
        {
            { Language: "english" } => "Hello!",
            { Language: "german", Status: "admin" } => "Hallo!",
            { Language: "french" } => "Salut!",
            { } => "Hello world!"
        };
    }
}

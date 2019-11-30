﻿using System;

namespace Creating_Exclusion_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person { Name = "Tom", Age = 17 };
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.Read();

        }
    }
    class Person
    {
        private int _age;
        public string Name { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18)
                {
                    throw new Exception("Лицам до 18 регистрация запрещена");
                }
                else
                {
                    Age = value;
                }
            }
        }
       
    }
}

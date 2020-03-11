using System;
using System.Collections;

namespace Collecionts.OperatorYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.Read();
        }
    }
    class Book
    {
        public string Name { get; set; }
        public Book(string name)
        {
            Name = name;
        }
    }
    class Library
    {
        private Book[] books;
        public Library()
        {
            books = new Book[] { new Book("Красное и чёрное"), new Book("Отцы и дети"), new Book("Война и Мир") };
        }
        public int Length
        {
            get { return books.Length; }
        }
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i<books.Length; i ++)
            {
                yield return books[i];
            }
        }

    }
    class Numbers
    {
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i<6; i++)
            {
                yield return i * i;
            }
        }
    }
}

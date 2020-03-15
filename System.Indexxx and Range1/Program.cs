using System;


namespace System.Indexxx_and_Range1
{
    class Program
    {
        static void Main(string[] args)
        {
            Index myIndex1 = 2;     // третий элемент
            Index myIndex2 = ^2;    // предпоследний элемент

            string[] people = { "Tom", "Bob", "Sam", "Kate", "Alice" };
            string selected1 = people[myIndex1];    // Sam
            string selected2 = people[myIndex2];    // Kate
            Console.WriteLine(selected1);
            Console.WriteLine(selected2);

            string[] people = { "Tom", "Bob", "Sam", "Kate", "Alice" };
            string[] peopleRange = people[1..4]; // получаем 2, 3 и 4-й элементы из массива
            foreach (var person in peopleRange)
            {
                Console.WriteLine(person);
            }
        }
    }
}

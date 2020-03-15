using System;

namespace Span1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = new string[] { "Tom", "Bill", "Bob", "Jim" };
            Span<string> peopleSpan = people;
            peopleSpan[1] = "Ann";
            Console.WriteLine(peopleSpan[2]);
            Console.WriteLine(peopleSpan.Length);
            foreach (var res in people)
            {
                Console.WriteLine(res);
            }

            int[] temperatures = new int[]
            {   10, 12, 13, 14, 15, 11, 13, 15, 16, 17,
                18, 16, 15, 16, 17, 14,  9,  8, 10, 11,
                12, 14, 15, 15, 16, 15, 13, 12, 12, 11
            };
            Span<int> temperaturesSpan = temperatures;
            Span<int> firsDecade = temperaturesSpan.Slice(0, 10);
            temperaturesSpan[0] = 25;
            Console.WriteLine(firsDecade[0]);
        }
    }
}

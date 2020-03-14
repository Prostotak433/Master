using System;

namespace DataTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();
            Console.WriteLine(date1);
            Console.WriteLine(DateTime.MinValue);
            Console.WriteLine(DateTime.MinValue);
            DateTime date2 = new DateTime(2020, 3, 14);
            Console.WriteLine(date2.ToLongDateString());
            DateTime date3 = new DateTime(2020, 3, 14, 17, 11, 33);
            Console.WriteLine(date3.DayOfWeek);

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Today);

            DateTime date4 = new DateTime(1582, 10, 5);
            Console.WriteLine(date4.DayOfWeek);

            DateTime date5 = new DateTime(2020, 3, 14, 17, 19, 33);
            DateTime date6 = new DateTime(2020, 3, 15, 21, 19, 33);
            Console.WriteLine(date5.Subtract(date6));
        }
    }
}

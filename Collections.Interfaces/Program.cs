using System;
using System.Collections;

namespace Collections.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach(var day in week)
            {
                Console.WriteLine(day);
            }
            Console.Read();
        }
    }
    
    class Week: IEnumerable
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                         "Friday", "Saturday", "Sunday" };
        public IEnumerator GetEnumerator()
        {
            return days.GetEnumerator();
        }
    }

}

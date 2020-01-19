using System;

namespace Sorting_objects_Interfaces
{
    interface IComparer
    {
        int Compare(object o1, object o2);
    }
    class PeopleComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            if (p1.Name.Length > p2.Name.Length)
                return 1;
            else if (p1.Name.Length < p2.Name.Length)
                return -1;
            else
                return 0;
        }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
           
          
        }
    }
}

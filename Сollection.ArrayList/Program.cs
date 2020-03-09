using System;
using System.Collections;
namespace Сollection.ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList() { 4.4, "GI", 22, };
            ArrayList list = new ArrayList();
            list.Add(2.2);
            list.Add(55);
            list.AddRange(new string[] { "Hello", "World" });
            
            foreach(object o in list)
            {
                Console.Write(o);
            }
            list.RemoveAt(0);
            list.Reverse();
            Console.WriteLine(list[0]);
            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.Read();
        }
    }
}

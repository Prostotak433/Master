using System;

namespace System.String1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = null;
            string s3 = new String('a', 6);
            string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
            Console.WriteLine(s1,s4);
        }
    }
}

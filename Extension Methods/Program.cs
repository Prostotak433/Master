using System;

namespace Extension_Methods
{
    public static class StringExec
    {
        public static int CharCount(this string str, char c)
        {
            int counter = 0;
            for(int i = 0; i<str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Привет мир";
            char c = 'и';
            int i = s.CharCount(c);
            Console.WriteLine(i);
            Console.Read();
        }
    }
}

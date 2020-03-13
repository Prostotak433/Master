using System;

namespace System.String1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = " hello";
            string s2 = " world";
            string s3 = String.Concat(s1, " Уебень");
            Console.WriteLine(s3);
            string[] values = new string[] { s1, s2, s3 };
            string s4 = String.Join(s1, values);
            Console.WriteLine(s4);
            char ch = 'o';
            int indexofChar = s1.IndexOf(ch);
            int Lastindex = s1.LastIndexOf(ch);
            Console.WriteLine(Lastindex);
            Console.WriteLine(indexofChar);
            string text = "И поэтому все так произошло";

            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            string text1 = "Хороший день";
            string subString = "замечательный ";

            text = text.Insert(8, subString);
            Console.WriteLine(text1);

            string s11 = "Ebyby";
            int ind = s11.Length - 1;
            s11 = s11.Remove(1,2);
            Console.WriteLine(s11);

        }

        
    }
}

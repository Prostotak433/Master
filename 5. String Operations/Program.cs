using System;

namespace _5._String_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "ab";
            int result = String.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
            string s3 = s1 + " " + s2;
            string s4 = String.Concat(s3, " ", s1, "!!!");
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            string s5 = "apple";
            string s6 = "a day";
            string s7 = "keeps";
            string s8 = "a doctor";
            string s9 = "away";
            string[] values = new string[] { s5, s6, s7, s8, s9 };
            String s10 = String.Join(" ", values);
            Console.WriteLine(s10);

            string s11 = "Hi people";
            char ch = 'e';
            int indexChar = s11.IndexOf(ch);
            Console.WriteLine(indexChar);
            char ch1 = 'e';
            int LastIndexChar = s11.LastIndexOf(ch1);
            Console.WriteLine(LastIndexChar);

            string text = "И поэтому все так произошло";
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            string text1 = "Hi its my mom";
            text1 = text1.Trim(new char[] { 'H', 'm' });
            Console.WriteLine(text1);
            text1 = text1.Substring(0, text1.Length-2);
            Console.WriteLine(text1);

            string textt = "Хороший день";
            string text4 = "замечательный ";
            textt = textt.Insert(8, text4);
            Console.WriteLine(textt);

            string text10 = "Nice Try";
            int ind = text10.Length - 2;
            text10 = text10.Remove(1, 3);
            Console.WriteLine(text10);

            string n1 = "Лoха крутой";
           
            n1 = n1.Replace("o", "Шляпа гуся");
            Console.WriteLine(n1);

            string n2 = "Serega";
            Console.WriteLine(n2.ToLower());
            Console.WriteLine(n2.ToUpper());





        }
    }
}

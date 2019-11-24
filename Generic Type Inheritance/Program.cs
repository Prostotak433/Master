using System;

namespace Generic_Type_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MixedAccount<string, int> acc8 = new MixedAccount<string, int>("1212") { Code = 12 + 31 };
            Account<string> acc10 = new MixedAccount<string, int>("1313") { Code = 15 + 13 };
            IntAccount<string> acc6 = new IntAccount<string>(5) { Code = "555" };
            Account<int> acc7 = new IntAccount<long>(13) { Code = 666 };
            StringAccount acc4 = new StringAccount("77");
            Account<string> acc5 = new StringAccount("88");
            Account<string> acc1 = new Account<string>("34");
            Account<int> acc2 = new UniversalAccount<int>(55);
            UniversalAccount<int> acc3 = new UniversalAccount<int>(66);
            Console.WriteLine(acc1.Id);
            Console.WriteLine(acc2.Id);
            Console.WriteLine(acc3.Id);
            Console.WriteLine(acc6.Id);
            Console.WriteLine(acc7.Id);
            Console.WriteLine(acc8.Id);
            Console.WriteLine(acc10.Id);
            Console.Read();
        }
    }
    class Account<T>
    {
        public T Id { get; private set; }
        public Account(T _id)
        {
            Id = _id;
        }
    }
    class UniversalAccount<T>:Account<T>
    {
        public UniversalAccount(T id) : base(id)
        {

        }
    }
    class StringAccount : Account<string>
    {
        public StringAccount(string id) : base(id)
        {

        }
    }
    class IntAccount<T> : Account<int>
    {
        public T Code { get; set; }
        public IntAccount(int id) : base(id)
        {
        }
    }
    class MixedAccount<T, K> : Account<T>
    where K : struct
    {
        public K Code { get; set; }
        public MixedAccount(T id) : base(id)
        {

        }
    }

}

using Class.Thread;
using System;

namespace Class.Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount s1 = new SavingAccount(50);
            SavingAccount s2 = new SavingAccount(100);
            Console.WriteLine("Interest Rate is : {0}", SavingAccount.GetInterestRate());
            SavingAccount s3 = new SavingAccount(1000.50);
            Console.WriteLine("Interest Rate is : {0}", SavingAccount.GetInterestRate());
            Console.ReadLine();
        }
    }
}
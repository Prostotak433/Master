using System;

namespace Static_members_and_modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Account.bonus);
            Account.bonus += 200;

        }
    }
    class Account
    {

        static int retirementAge = 60;
        public static void ChangeRetirementAge(int years)
        {
            retirementAge += years;
        }
        public void DisplayRetirementAge()
        {
            Console.WriteLine(retirementAge);
        }
    }
}

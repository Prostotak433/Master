using System;
using System.Collections.Generic;
using System.Text;

namespace Class.Thread
{
    public class SavingAccount
    {
        public double currBalance;
        public static double currInterestRate;
        public SavingAccount(double balance)
        {
            currInterestRate = 0.04;
            currBalance = balance;
        }
        public static void SetIneterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Use_Interfaces
{
    class Person : IAccount, IClient
    {
        int _sum;
        public string Name { get; set; }
        public Person(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }
        public int CurrentSum { get { return _sum; } }
        public void Put(int sum) { _sum += sum; }
        public void WintWithdraw(int sum)
        {
            if(_sum>=sum)
            {
                _sum -= sum;
            }
        }
    }
}   

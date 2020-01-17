using System;
using System.Collections.Generic;
using System.Text;

namespace Use_Interfaces
{
    interface IAccount
    {
       int CurrentSum { get; }
        void Put(int sum);
        void WintWithdraw(int sum);    
    }
    interface IClient
    {
        string Name { get; set; }
    }
}

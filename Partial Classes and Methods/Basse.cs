using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_Classes_and_Methods
{
    public partial class PersonBase
    {
        partial void DoElse();
        public void DoSom()
        {
            Console.WriteLine("start");
            DoElse();
            Console.WriteLine("Finish");
        }
    }
}

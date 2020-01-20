using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_Classes_and_Methods
{
    public partial class PersonBase
    {
        partial void DoElse()
        {
            Console.WriteLine("READ");
        }
    }
}

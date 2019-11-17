using System;

namespace Null
{
    class Program
    {
        static void Main(string[] args)
        {
            object s = null;
            string o = null;
            if (user != null && user.Phone != null && user.Phone.Company != null)
            {
                string companyName = user.Phone.Company.Name;
                Console.WriteLine(companyName);
            }
        }
    }
}

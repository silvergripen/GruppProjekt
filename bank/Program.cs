using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Application application = new Application();
            //application.Start();
            Account account = new Account();
            Console.WriteLine(account.Balance());
            //SavingAccount save1 = new SavingAccount();
        }
    }
}

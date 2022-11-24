using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace bank
{
    class Program 
    {
        static void Main(string[] args)
        {
            Application application = new Application();
            //application.Start();
            application.Start();
            

            // ************** Här funkar det att lägga till nya konton med samma kod men inte i menyerna *******************

            //Customer cust = new Customer();

            //Dictionary<string, string> dictAccounts = new Dictionary<string, string>();
            //Console.WriteLine("Please enter you social security number again:");
            //string inputPersonNr = Console.ReadLine();
            //cust.PersonNr = inputPersonNr;
            //dictAccounts.Add(cust.PersonNr, cust.CheckingAccount(cust.PersonNr));
            //Console.WriteLine("You have added a new checking account.");
            //Thread.Sleep(3000);

            //Console.WriteLine("This is a list of your accounts:");

            //foreach (var item in dictAccounts)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Press Enter to to back to main menu.");
            //Console.ReadKey();
        }
    }
}

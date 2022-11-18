using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Customer : User
    {
        public string Clearance = "kund";

        //struct CustAccount
        //{
        //    string personNr;
        //    string clearing;
        //    string accountNr;
        //    double rate;
        //    double interst;
        //}
        public Customer()
        {

        }

        public void AddAccount(string personNr)
        {
            this.PersonNr = personNr;


        }
        public void AddCheckingAccount()
        {
            Console.WriteLine("You have added a new checking account");
            Console.ReadKey();
        }
        public void AddSavingsAccount()
        {
            Console.WriteLine("You have added a new savings account");
            Console.ReadKey();
        }
        public void ListOfAccounts()
        {
            Console.WriteLine(@"
This will show a list of all your accounts.
You'll be able to click on a specific account and interact with it.
Click enter to go back to the main menu");
            Console.ReadKey();
        }
    } 
}

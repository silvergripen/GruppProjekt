using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Customer : User
    {
        public string Clearance = "kund";

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
        private string Account1(string personNr)
        {
            Account accountClass = new Account();
            string savingsAccount1 = "1";
            PersonNr = personNr;
            return $"{accountClass.clearingNr}, {personNr}-{savingsAccount1}";
        }

        private string Account2(string personNr)
        {
            Account accountClass = new Account();
            string savingsAccount2 = "2";
            PersonNr = personNr;
            return $"{accountClass.clearingNr}, {personNr}-{savingsAccount2}";
        }

        private string Account3(string personNr)
        {
            Account accountClass = new Account();
            string savingsAccount3 = "3";
            PersonNr = personNr;
            return $"{accountClass.clearingNr}, {personNr}-{savingsAccount3}";
        }

        private string Account4(string personNr)
        {
            Account accountClass = new Account();
            string savingsAccount4 = "4";
            PersonNr = personNr;
            return $"{accountClass.clearingNr}, {personNr}-{savingsAccount4}";
        }
    } 
}

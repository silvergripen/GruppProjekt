using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace bank
{
    class Customer : User
    {
        Dictionary<string, string> dictAccounts = new Dictionary<string, string>();
        Application applicationClass = new Application();

        public void AddCheckingAccount()
        {
            Console.WriteLine("Please enter you social security number again:");
            string inputPersonNr = Console.ReadLine();
            this.PersonNr = inputPersonNr;
            dictAccounts.Add(PersonNr, CheckingAccount(PersonNr));
            AddedAccount();
        }
        public void AddSavingsAccount()
        {
            SavingsAccount savingsAccountClass = new SavingsAccount();
            Console.WriteLine("Please enter you social security number again:");
            string inputPersonNr = Console.ReadLine();
            this.PersonNr = inputPersonNr;
            dictAccounts.Add(PersonNr, savingsAccountClass.NewSavingsAccount(PersonNr));
            AddedAccount();
        }
        public void ListOfAccounts()
        {
            Console.WriteLine("This is a list of your accounts:");

            foreach (var item in dictAccounts)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to to back to main menu.");
            Console.ReadKey();
            applicationClass.RunCustomerMenu();
        }
        public string CheckingAccount(string personNr)
        {
            Account accountClass = new Account();
            string CheckingAccount = "1";
            PersonNr = personNr;
            return $"{accountClass.clearingNr}, {personNr}-{CheckingAccount}";
        }
        public void AddedAccount()
        {
            Console.WriteLine("You have added a new account.");
            Thread.Sleep(3000);
            applicationClass.RunCustomerMenu();
        }

    } 
}

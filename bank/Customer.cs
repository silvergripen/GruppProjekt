using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace bank
{
    class Customer : User
    {
        List<string> AccountList = new List<string>();
        List<string> SavingsAccountList = new List<string>();
        //Dictionary<string, string> dictAccounts = new Dictionary<string, string>();
        Application applicationClass = new Application();
        public void AddCheckingAccount()
        {
            Console.WriteLine("Please enter you social security number again:");
            string inputPersonNr = Console.ReadLine();
            this.PersonNr = inputPersonNr;

            // Behöver felhantering
            Console.WriteLine("Please enter the amount of money you want to add to your account in numbers:");
            double inputAcocuntBalanse = Double.Parse(Console.ReadLine());
            CheckingAccount checkingAccount = new CheckingAccount(inputAcocuntBalanse);
            
            string addCheckingAccount = checkingAccount.NewCheckingAccount(PersonNr);
            AccountList.Add(addCheckingAccount);
            AddedAccount();
        }
        public void AddSavingsAccount()
        {
            Console.WriteLine("Please enter you social security number again:");
            string inputPersonNr = Console.ReadLine();
            this.PersonNr = inputPersonNr;

            // Behöver felhantering
            Console.WriteLine("Please enter the amount of money you want to add to your account in numbers:");
            double inputAcocuntBalanse = Double.Parse(Console.ReadLine());
            SavingsAccount savingsAccount = new SavingsAccount(inputAcocuntBalanse);

            string addSavingsAccount = savingsAccount.NewSavingsAccount(PersonNr);
            AccountList.Add(addSavingsAccount);
            AddedAccount();
        }
        public void ListOfAccounts()
        {
            Console.WriteLine("This is a list of your checking accounts:");

            foreach (string cAccount in AccountList)
            {
                Console.WriteLine(cAccount);
            }

            Console.WriteLine("\nThis is a list of your savings accounts:");
            foreach (string sAccount in SavingsAccountList)
            {
                Console.WriteLine(sAccount);
            }

            Console.WriteLine("\nPress Enter to to back to main menu.");
            Console.ReadKey();
            applicationClass.RunCustomerMenu();
        }

        public void AddedAccount()
        {
            Console.WriteLine("You have added a new account.");
            Thread.Sleep(3000);
            applicationClass.RunCustomerMenu();
        }

    } 
}

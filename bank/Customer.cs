using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace bank
{
    class Customer : User
    {
        List<SavingsAccount> SavingsAccountList = new List<SavingsAccount>();
        List<CheckingAccount> CheckingAccountList = new List<CheckingAccount>();

        Application applicationClass = new Application();
        public void AddCheckingAccount(Customer user)
        {
            Console.WriteLine("Please enter you social security number again:");
            string inputPersonNr = Console.ReadLine();

            //if(inputPersonNr != user.PersonNr)
            //{
            //    Console.WriteLine("Incorrect social security number");
            //}

            // Behöver felhantering
            Console.WriteLine("Please enter the amount of money you want to add to your account in numbers:");
            double inputAccountBalance = Double.Parse(Console.ReadLine());
            CheckingAccount checkingAccount = new CheckingAccount(inputAccountBalance);
            
            string addCheckingAccount = checkingAccount.NewCheckingAccount(PersonNr);
            checkingAccount.displayInformation = addCheckingAccount;
            user.CheckingAccountList.Add(checkingAccount);
            AddedAccount(user);
        }
        public void AddSavingsAccount(Customer user)
        {
            Console.WriteLine("Please enter you social security number again:");
            string inputPersonNr = Console.ReadLine();
            this.PersonNr = inputPersonNr;

            // Behöver felhantering
            Console.WriteLine("Please enter the amount of money you want to add to your account in numbers:");
            double inputAccountBalance = Double.Parse(Console.ReadLine());
            SavingsAccount savingsAccount = new SavingsAccount(inputAccountBalance);

            string addSavingsAccount = savingsAccount.NewSavingsAccount(PersonNr);
            savingsAccount.displayInformation = addSavingsAccount;
            user.SavingsAccountList.Add(savingsAccount);
            AddedAccount(user);
        }
        public void ListOfAccounts(Customer user)
        {
            Console.WriteLine("This is a list of your checking accounts:");

            foreach (CheckingAccount cAccount in user.CheckingAccountList)
            {
                Console.WriteLine(cAccount.displayInformation);
            }

            Console.WriteLine("\nThis is a list of your savings accounts:");
            foreach (SavingsAccount sAccount in user.SavingsAccountList)
            {
                Console.WriteLine(sAccount.displayInformation);
            }

            Console.WriteLine("\nPress Enter to to back to main menu.");
            Console.ReadKey();
            applicationClass.RunCustomerMenu(user);
        }

        public void AddedAccount(Customer user)
        {
            Console.WriteLine("You have added a new account.");
            Thread.Sleep(3000);
            applicationClass.RunCustomerMenu(user);
        }

    } 
}

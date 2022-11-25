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
            CheckingPersonNr(user);

            Console.WriteLine("Please enter the amount of money you want to add to your account in numbers:");
            double inputBalance = Double.Parse(Console.ReadLine());
            CheckingAccount checkingAccount = new CheckingAccount(inputBalance);
            
            string addCheckingAccount = checkingAccount.NewCheckingAccount(user.PersonNr);
            checkingAccount.displayInformation = addCheckingAccount;
            user.CheckingAccountList.Add(checkingAccount);
            AddedAccount(user);
        }
        public void AddSavingsAccount(Customer user)
        {
            CheckingPersonNr(user);

            Console.WriteLine("Please enter the amount of money you want to add to your account in numbers:");
            double inputAccountBalance = Double.Parse(Console.ReadLine());
            SavingsAccount savingsAccount = new SavingsAccount(inputAccountBalance);

            string addSavingsAccount = savingsAccount.NewSavingsAccount(PersonNr);
            savingsAccount.displayInformation = addSavingsAccount;
            user.SavingsAccountList.Add(savingsAccount);
            AddedAccount(user);
        }
        private void CheckingPersonNr(Customer user)
        {
            string cInputPersonNr;
            Application applicationClass = new Application();
            do
            {
                Console.WriteLine("Please enter you social security number again:");
                cInputPersonNr = Console.ReadLine();
                foreach (User personNr in userList.FindAll(item => item.PersonNr == cInputPersonNr)) { }
                if (user.PersonNr == cInputPersonNr)
                {
                    Console.WriteLine("Correct social security number");
                }
                else
                {
                    maxTries--;
                    Console.WriteLine($"Incorrect social security number, you have {maxTries} tries left");
                    Thread.Sleep(1500);
                }
                if (maxTries == 0)
                {
                    Console.WriteLine("Sorry the social security number doesn't exist, you will be logged out.");
                    Thread.Sleep(2000);
                    applicationClass.Start();
                }
            }
            while (cInputPersonNr != PersonNr && maxTries >= 1);
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

        private void AddedAccount(Customer user)
        {
            Console.WriteLine("You have added a new account.");
            Thread.Sleep(3000);
            applicationClass.RunCustomerMenu(user);
        }

    } 
}

using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Customer : User
    {
        public Dictionary<string, string> dictAccounts = new Dictionary<string, string>();

        public void AddCheckingAccount()
        {
            Application applicationClass = new Application();
            applicationClass.Logo();

            string prompt = "Here you can choose a slot and add an account";
            string[] options = { "Checking account 1", "Checking account 2",
                "Checking account 3", "Checking account 4", "Main menu"};
            Menu menu = new Menu(prompt, options);
            int menuSelect = menu.Run();

            switch (menuSelect)
            {
                case 0:
                    dictAccounts.Add(PersonNr, Account1(PersonNr));
                    break;
                case 1:
                    dictAccounts.Add(PersonNr, Account2(PersonNr));
                    break;
                case 2:
                    dictAccounts.Add(PersonNr, Account3(PersonNr));
                    break;
                case 3:
                    dictAccounts.Add(PersonNr, Account4(PersonNr));
                    break;
                case 4:
                    applicationClass.RunCustomerMenu();
                    break;
            }
        }
        public void AddSavingsAccount()
        {
            SavingsAccount savingsAccountClass = new SavingsAccount();
            Application applicationClass = new Application();
            applicationClass.Logo();

            string prompt = "Here you can choose a slot and add an account";
            string[] options = { "Savings account", "Main menu"};
            Menu menu = new Menu(prompt, options);
            int menuSelect = menu.Run();

            switch (menuSelect)
            {
                case 0:
                    dictAccounts.Add(PersonNr, savingsAccountClass.NewSavingsAccount1(PersonNr));
                    break;
                case 1:
                    applicationClass.RunCustomerMenu();
                    break;
            }
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

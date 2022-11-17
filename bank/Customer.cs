using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Customer : User
    {
        public int defaultAccountNr = 1;
        public int secondAccountNr = 2;
        public int thirdAccountNr = 3;
        public int forthAccountNr = 4;
        public int fihAccountNr = 5;
        public string Clearance = "kund";
        readonly Application applicationClass = new Application();
        struct CustAccount
        {
            string clearing;
            string accountNr;
            double rate;
            double interst;
        }
        public Customer()
        {

        }

        public void AddAccount(string personNr)
        {
            this._PersonNr = personNr;
            AddAccountMenu();


        }
        private void AddCheckingAccount()
        {
            Console.WriteLine("You have added a new checking account");
            Console.ReadKey();
        }
        private void AddSavingsAccount()
        {
            Console.WriteLine("You have added a new savings account");
            Console.ReadKey();
        }

        private void ChangeCurrency()
        {
            throw new NotImplementedException();
        }

        private void ListOfAccounts()
        {
            throw new NotImplementedException();
        }

        private void OverviewAllAccounts()
        {
            throw new NotImplementedException();
        }

        private void TakeLoan()
        {
            throw new NotImplementedException();
        }

        private void TransferMyAccounts()
        {
            throw new NotImplementedException();
        }

        private void TransferOtherAccounts()
        {
            throw new NotImplementedException();
        }

        private void AddAccountMenu()
        {
            applicationClass.Logo();
            string prompt = @"
Here you can add a new account. Please choose what kind of account you want to add
(Use the arrow keys to cycle through options and press Enter to select.";
            string[] options = { "Checking account", "Savings account", "Go back to main menu" };
            Menu mainMenu = new Menu(prompt, options);
            int menuSelect = mainMenu.Run();

            switch (menuSelect)
            {
                case 0:
                    AddCheckingAccount();
                    ChooseCurrencyMenu();
                    break;
                case 1:
                    AddSavingsAccount();
                    ChooseCurrencyMenu();
                    break;
                case 2:
                    applicationClass.RunCustomerMenu();
                    break;
            }
        }

        private void ChooseCurrencyMenu()
        {
            string prompt = @"
What currency would you like to open this account in?
(Use the arrow keys to cycle through options and press Enter to select.";
            string[] options = { "EUR", "USD", "DKK", "NOK", "ISK" };
            Menu mainMenu = new Menu(prompt, options);
            int menuSelect = mainMenu.Run();

            switch (menuSelect)
            {
                case 0:
                    Console.WriteLine("You have chosen EUR");
                    Console.ReadKey();
                    break;
                case 1:
                    Console.WriteLine("You have chosen USD");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("You have chosen DKK");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("You have chosen NOK");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("You have chosen ISK");
                    Console.ReadKey();
                    break;
            }
        }
    } 
}

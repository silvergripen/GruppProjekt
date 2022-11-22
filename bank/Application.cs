using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace bank
{
    class Application
    {
        public void Start()
        {
            // Tile of the console window
            Console.Title = "PearBank application";
            LoginScreen();
        }
 
        private void LoginScreen() // ********************** LOGIN SCREEN ***********************************************
        {
            Logo();
            User userClass = new User();
            Console.WriteLine("Welcome to the PearBank app.");
            userClass.VerifyLogin();
        }
        
        public void RunCustomerMenu() // ********************** CUSTOMER MENU ***********************************************
        {// Kommer att bli private, bara public nu för att kunna testa utan Login()
            Customer customerClass = new Customer();
            string prompt = $"Welcome {customerClass.PersonNr} to your bank account. \n(Use the arrow keys to cycle through options and press Enter to select.)";
            string[] options = { "My accounts", "Open new account", "Log out", "Exit" };
            Menu menu = new Menu(prompt, options);
            int menuSelect = menu.Run();

            switch (menuSelect)
            {
                case 0:
                    Logo();
                    customerClass.ListOfAccounts();
                    RunCustomerMenu();
                    break;
                case 1:
                    Logo();
                    AddAccountMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("You just logged out.");
                    Thread.Sleep(3000);
                    LoginScreen();
                    break;
                case 3:
                    Logo();
                    ExitApp();
                    break;
            }
        }
       
        public void RunAdminMenu() // ********************** ADMIN MENU ***********************************************
        {// Kommer att bli private, bara public nu för att kunna testa utan Login()
            Admin adminClass = new Admin();
            string prompt = $"Welcome to settings admin {adminClass.PersonNr}. \n(Use the arrow keys to cycle through options and press Enter to select.)";
            string[] options = { "Create new customer", "Change exchange rates", "Log out", "Exit" };
            Menu menu = new Menu(prompt, options);
            int menuSelect = menu.Run();

            switch (menuSelect)
            {
                case 0:
                    Logo();
                    adminClass.AddCustomer();
                    Console.WriteLine("Customer added.");
                    Thread.Sleep(3000);
                    RunAdminMenu();
                    break;
                case 1:
                    Logo();
                    ChangeExchangeRateMenu();
                    RunAdminMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("You just logged out.");
                    Thread.Sleep(3000);
                    LoginScreen();
                    break;
                case 3:
                    Logo();
                    ExitApp();
                    break;
            }
        }
        private void ChangeExchangeRateMenu() // ********************** ADMINS CHANGE CURRENCY MENU ***********************************************
        {
            string prompt = "What currency would you like to change?";
            string[] options = { "SEK", "EUR", "USD", "DKK", "NOK", "ISK" };
            Menu menu = new Menu(prompt, options);
            int menuSelect = menu.Run();

            switch (menuSelect)
            {
                case 0:
                    Console.WriteLine("You have chosen SEK");
                    Thread.Sleep(3000);
                    RunCustomerMenu();
                    break;
                case 1:
                    Console.WriteLine("You have chosen EUR");
                    Thread.Sleep(3000);
                    RunCustomerMenu();
                    break;
                case 2:
                    Console.WriteLine("You have chosen USD");
                    Thread.Sleep(3000);
                    RunCustomerMenu();
                    break;
                case 3:
                    Console.WriteLine("You have chosen DKK");
                    Thread.Sleep(3000);
                    RunCustomerMenu();
                    break;
                case 4:
                    Console.WriteLine("You have chosen NOK");
                    Thread.Sleep(3000);
                    RunCustomerMenu();
                    break;
                case 5:
                    Console.WriteLine("You have chosen ISK");
                    Thread.Sleep(3000);
                    RunCustomerMenu();
                    break;
            }
        }
        private void AddAccountMenu() // ********************** CUSTOMER ADD ACCONT MENU ***********************************************
        {
            Customer customerClass = new Customer();

            string prompt = "Here you can open a new account. Please choose what kind of account you want to add";
            string[] options = { "Checking account", "Savings account", "Go back to main menu", "Log out", "Exit" };
            Menu menu = new Menu(prompt, options);
            int menuSelect = menu.Run();

            switch (menuSelect)
            {
                case 0:
                    Logo();
                    customerClass.AddCheckingAccount();
                    Console.WriteLine($"You have added: {customerClass.dictAccounts.ContainsKey(customerClass.PersonNr)}");
                    break;
                case 1:
                    Logo();
                    customerClass.AddSavingsAccount();
                    break;
                case 2:
                    Logo();
                    RunCustomerMenu();
                    break;
            }
        }

        private void ExitApp()
        {
            Console.WriteLine("You have chosen to exit. The program will end.");
            Thread.Sleep(4000); // Lets the program paus for 4 sec before ending
            Environment.Exit(0);
        }
        public void Logo()
        {
            Console.Clear();
            Console.WriteLine(@"
 ______                   ______              _     
(_____ \                 (____  \            | |    
 _____) )____ _____  ____ ____)  )_____ ____ | |  _ 
|  ____/ ___ (____ |/ ___)  __  ((____ |  _ \| |_/ )
| |    | ____/ ___ | |   | |__)  ) ___ | | | |  _ ( 
|_|    |_____)_____|_|   |______/\_____|_| |_|_| \_)
----------------------------------------------------");
        }
    }
}

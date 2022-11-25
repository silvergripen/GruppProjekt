using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace bank
{
    class Application
    {
        Admin adminClass = new Admin();
        public void Start()
        {
            Console.Title = "PearBank application";
            LoginScreen();
        }
 
        private void LoginScreen()
        {
            Logo();
            Console.WriteLine("Welcome to the PearBank app.");
            adminClass.VerifyLogin();
        }

        public void RunCustomerMenu(Customer user)
        {
            string prompt = $"Welcome {user.PersonNr} to your bank account. \n(Use the arrow keys to cycle through options and press Enter to select.)";
            string[] options = { "My accounts", "Open new account", "Log out", "Exit" };
            Menu menu = new Menu(prompt, options);
            int menuSelect = menu.Run();

            switch (menuSelect)
            {
                case 0:
                    Logo();
                    user.ListOfAccounts(user);
                    RunCustomerMenu(user);
                    break;
                case 1:
                    Logo();
                    AddAccountMenu(user);
                    break;
                case 2:
                    LoggingOut();
                    break;
                case 3:
                    Logo();
                    ExitApp();
                    break;
            }
        }

        public void RunAdminMenu()
        {
            string prompt = $"Welcome to settings admin {adminClass.PersonNr}. \n(Use the arrow keys to cycle through options and press Enter to select.)";
            string[] options = { "Create new customer", "Log out", "Exit" };
            Menu menu = new Menu(prompt, options);
            int menuSelect = menu.Run();

            switch (menuSelect)
            {
                case 0:
                    Logo();
                    adminClass.AddCustomer();
                    Console.WriteLine("Customer added.");
                    Thread.Sleep(2500);
                    RunAdminMenu();
                    break;
                case 1:
                    LoggingOut();
                    break;
                case 2:
                    Logo();
                    ExitApp();
                    break;
            }
        }
        public void AddAccountMenu(Customer user)
        {
            string prompt = "Here you can open a new account. Please choose what kind of account you want to add";
            string[] options = { "Checking account", "Savings account", "Go back to main menu", "Log out", "Exit" };
            Menu menu = new Menu(prompt, options);
            int menuSelect = menu.Run();

            switch (menuSelect)
            {
                case 0:
                    Logo();
                    user.AddCheckingAccount(user);
                    break;
                case 1:
                    Logo();
                    user.AddSavingsAccount(user);
                    break;
                case 2:
                    Logo();
                    RunCustomerMenu(user);
                    break;
            }
        }
        private void LoggingOut()
        {
            Console.Clear();
            Console.WriteLine("You're being logged out.");
            Thread.Sleep(3000);
            LoginScreen();
        }
        private void ExitApp()
        {
            Console.WriteLine("You have chosen to exit. The program will end.");
            Thread.Sleep(4000);
            Environment.Exit(0);
        }
        public void OutOfTries()
        {
            Console.WriteLine("You have used up all your tries. The program will restart.");
            Thread.Sleep(4000);
            Start();
        }
        public void Logo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
 ______                   ______              _     
(_____ \                 (____  \            | |    
 _____) )____ _____  ____ ____)  )_____ ____ | |  _ 
|  ____/ ___ (____ |/ ___)  __  ((____ |  _ \| |_/ )
| |    | ____/ ___ | |   | |__)  ) ___ | | | |  _ ( 
|_|    |_____)_____|_|   |______/\_____|_| |_|_| \_)
----------------------------------------------------");
            Console.ResetColor();
        }
    }
}

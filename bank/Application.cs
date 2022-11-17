using System;
using System.Collections.Generic;
using System.Text;

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
        // ********************* LOGIN SCREEN NEEDS TO BE FIXED **************************************
        public void LoginScreen()
        {
            User userLogin = new User();
            Logo();
            Console.WriteLine(@"Welcome to the PearBank app. Please enter your information.");

            userLogin.UserInput();
        }
        // ********************* LOGIN SCREEN NEEDS TO BE FIXED **************************************
        public void RunCustomerMenu()
        {
            Logo();
            string prompt = "Welcome to your bank account. \n(Use the arrow keys to cycle through options and press Enter to select.";
            string[] options = { "Balance", "Accounts", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int menuSelect = mainMenu.Run();

            switch (menuSelect)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    RunSecondChoice();
                    break;
                case 2:
                    ExitApp();
                    break;
            }
        }

        private void RunFirstChoice()
        {
            Console.WriteLine("Savings");
            RunCustomerMenu();
        }
        private void RunSecondChoice()
        {
            Console.WriteLine("Accounts");
            RunCustomerMenu();
        }
        private void ExitApp()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
        public void Logo()
        {
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

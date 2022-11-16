using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Application
    {
        public void Start()
        {
            Console.Title = "PearBank application";
            LogInScreen();
        }
        // ********************* LOGIN SCREEN NEEDS TO BE FIXED **************************************
        public void LogInScreen()
        {
            Logo();
            Console.WriteLine(@"Welcome to the PearBank app. Please enter your information.");

            Console.WriteLine("Please enter your username: ");
            Console.WriteLine("Please enter your password: ");
        }
        // ********************* LOGIN SCREEN NEEDS TO BE FIXED **************************************
        public void RunMainMenu()
        {
            Logo();
            string prompt = "Welcome to your bank account. \n(Use the arrow keys to cycle through options and press Enter to select.";
            string[] options = { "Balance", "Accounts", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int MenuSelect = mainMenu.Run();

            switch (MenuSelect)
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
            RunMainMenu();
        }
        private void RunSecondChoice()
        {
            Console.WriteLine("Accounts");
            RunMainMenu();
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

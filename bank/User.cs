using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace bank
{
    class User
    {
        private string personNr;
        private string passWord;
        protected int maxTries = 3;
        public string PersonNr { get => personNr; set => personNr = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public bool AdminClearance { get; set; }

        public Dictionary<string, User> dictUser = new Dictionary<string, User>();

        private bool ValidatePassword(string aPersonNr, string aPassWord)
        {
            this.PersonNr = aPersonNr;
            this.PassWord = aPassWord;
            return dictUser.Any(x => x.Key == PersonNr && x.Value.PassWord == PassWord); //Returnar en sann
                                                                                         //
        }
        public void AdminUser()                 
        {
            PersonNr = "123";
            dictUser.Add(PersonNr, new User    
            {
                PassWord = "0000",
                AdminClearance = true
            });
        }

        public void VerifyLogin()
        {
            Application applicationClass = new Application();
            AdminUser();                                                        // Lade DefaultUser/AdminUser här istället så fanns den med i inlogget för mig / Madde
            bool isValid;
            bool loggedIn = false;
            AdminClearance = false;

            Console.WriteLine("Please enter your social security number:");
            var inputPersonNr = Console.ReadLine();

            while (loggedIn == false)                                           // Behöver lägga in att man bara får tre försök här också / Madde
            {
                if (dictUser.ContainsKey(inputPersonNr))
                {
                    Console.WriteLine("Your social security number is correct.");
                    Thread.Sleep(2500);
                    loggedIn = true;
                }
                else
                {
                    Console.WriteLine("Sorry, your social security number doesn't exist, please try again.");
                    inputPersonNr = Console.ReadLine();
                }

            }//Behövs dock kanske en foreach loop genom dictionary då om nycklen är PersonNr? / Madde


            do //En loop som gör så du bara har 3 försök på dig för att logga in.
            {
                Console.Clear();
                applicationClass.Logo();
                Console.WriteLine("Please enter your password:");
                var inputPassWord = Console.ReadLine();
                isValid = ValidatePassword(inputPersonNr, inputPassWord);
                maxTries--;
                if (isValid == true)
                {
                    if (ValidateAdmin(inputPersonNr) == true)
                    {
                        Console.WriteLine("You are logging in as admin");
                        Thread.Sleep(2500);
                        applicationClass.RunAdminMenu();
                    }
                    else
                    {
                        Console.WriteLine("You are logging in as a customer");
                        Thread.Sleep(2500);
                        applicationClass.RunCustomerMenu();
                    }
                }
                if (maxTries >= 1)                                                 
                {
                    Console.WriteLine("Sorry, wrong password. \nYou now have: " + maxTries + " tries left.");
                    Thread.Sleep(3000);
                }
            }
            while (maxTries >= 1 && isValid == false);

            applicationClass.OutOfTries();
        }

        public bool ValidateAdmin(string a_PersonNr)
        {
            this.PersonNr = a_PersonNr;
            AdminClearance = dictUser.Any(x => x.Key == PersonNr && x.Value.AdminClearance == true); //Returnar en sann 
            return AdminClearance;
        }
    }
}

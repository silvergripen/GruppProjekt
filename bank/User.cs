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

        public List<Customer> userList = new List<Customer>();

        private Customer ValidatePassword(string aPersonNr, string aPassword)
        {
            foreach(Customer user in userList)
            {
                if(user.PersonNr == aPersonNr && user.PassWord == aPassword)
                {
                    return user;
                }
            }
            return null;
        }

        public void AdminUser()
        {
            userList.Add(new Customer
            {
                PersonNr = "123",
                PassWord = "0000",
                AdminClearance = true
            });
        }

        public void VerifyLogin()
        {
            Application applicationClass = new Application();
            AdminUser();
            bool isValid;
            bool loggedIn = false;
            AdminClearance = false;

            Console.WriteLine("Please enter your social security number (YYMMDD-NNNNN):");
            var inputPersonNr = Console.ReadLine();

            while (loggedIn != true)                                         
            {
                foreach(var iUser in userList)
                { 
                    if (iUser.PersonNr == inputPersonNr)
                        {
                            Console.WriteLine("Your social security number is correct.");
                            Thread.Sleep(2500);
                            loggedIn = true;
                            break;
                    }
                }
                if(loggedIn != true)
                {
                    Console.WriteLine("Sorry, that social security number doesn't exist. \n\nPlease enter your social security number (YYMMDD-NNNNN):");
                    inputPersonNr = Console.ReadLine();
                }
            }

            Console.Clear();
            applicationClass.Logo();
            do
            {
                Console.WriteLine("Please enter your password:");
                var inputPassWord = Console.ReadLine();
                var user = ValidatePassword(inputPersonNr, inputPassWord);
                if(user == null)
                {
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
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
                        applicationClass.RunCustomerMenu((Customer)user);
                    }
                }
                if (maxTries >= 1)                                                 
                {
                    Console.WriteLine("Sorry, wrong password. \nYou now have: " + maxTries + " tries left.\n");
                    Thread.Sleep(2000);
                }
            }
            while (maxTries >= 1 && isValid == false);

            applicationClass.OutOfTries();
        }

        public bool ValidateAdmin(string personNr)
        {
            foreach (Customer user in userList)
            {
                if (user.PersonNr == personNr )
                {
                    return user.AdminClearance;
                }
            }
            return false;
        }
    }
}

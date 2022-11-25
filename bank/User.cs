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

        public List<User> userList = new List<User>();

        private User ValidatePassword(string aPersonNr, string aPassword)
        {
            foreach(User user in userList)
            {
                if(user.personNr == aPersonNr && user.passWord == aPassword)
                {
                    return user;
                }
            }
            return null;
        }

        public void AdminUser()
        {
            userList.Add(new User
            {
                personNr = "123",
                PassWord = "0000",
                AdminClearance = true
            });
        }

        public void VerifyLogin()
        {
            AdminUser();                                               
            bool isValid;
            bool loggedIn = false;
            AdminClearance = false;

            Console.WriteLine("Please enter your social security number:");
            var inputPersonNr = Console.ReadLine();

            while (loggedIn == false)                                         
            {
                foreach(var user in userList)
                {
                    if(user.personNr == inputPersonNr)
                    {
                        Console.WriteLine("Your social security number is correct.");
                        Thread.Sleep(2500);
                        loggedIn = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, your social security number doesn't exist, please try again.");
                        inputPersonNr = Console.ReadLine();
                    }
                }
            }

            do
            {
                Console.Clear();
                applicationClass.Logo();
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
                    Console.WriteLine("Sorry, wrong password. \nYou now have: " + maxTries + " tries left.");
                    Thread.Sleep(3000);
                }
            }
            while (maxTries >= 1 && isValid == false);

            OutOfTries();
        }

        public bool ValidateAdmin(string personNr)
        {
            foreach (User user in userList)
            {
                if (user.personNr == personNr )
                {
                    return user.AdminClearance;
                }
            }
            return false;
        }

        protected void OutOfTries()
        {
            Application applicationClass = new Application();
            Console.WriteLine("You have used up all your tries. The program will restart.");
            Thread.Sleep(4000);
            applicationClass.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        private bool ValidatePassword(string personNr, string password)
        {

            return dictUser.Any(x => x.Key == personNr && x.Value.PassWord == password); //Returnar en sann
                                                                                         //
        }
        public void DefaultUser()                 // Var DefaultUser tänkt som AdminUser?
        {
            dictUser.Add("123", new User     // PersonNr borde enklast vara nyckeln right? / Madde
            {

                PassWord = "0000",
                AdminClearance = true
            });
        }

        public void VerifyLogin()
        {
            bool loggedIn = false;
            AdminClearance = false;
            Console.WriteLine("Skriv ditt Personnummer");
            var inputUName = Console.ReadLine();
            while (loggedIn == false)
            {
                if (dictUser.ContainsKey(inputUName))
                {
                    Console.WriteLine("Ditt personnummer finns i systemet");
                    loggedIn = true;
                }
                else
                {
                    Console.WriteLine("Vi hittar inte ditt personnummer i systemet vänligen försök igen");
                    inputUName = Console.ReadLine();
                }

            }//Behövs dock kanske en foreach loop genom dictionary då om nycklen är PersonNr? / Madde

            bool isValid;

            do //En loop som gör så du bara har 3 försök på dig för att logga in.
            {

                Console.WriteLine("Skriv ditt lösenord");
                var inputUPass = Console.ReadLine();
                isValid = ValidatePassword(inputUName, inputUPass);
                maxTries--;
                Console.WriteLine(isValid ? "Du är inloggad" : "Gissat fel");       // Här kan vi lägga in att om dom är inloggad som user så RunCustomerMenu()
                if (maxTries >= 1)                                                  // eller som admin så RunAdminMenu(). / Madde
                {
                    Console.WriteLine(maxTries + " Försök kvar");
                }
            }
            while (maxTries >= 1 && isValid == false);
        }

        public bool ValidateAdmin(string aPersonNr)
        {
            this.PersonNr = aPersonNr;
            AdminClearance = dictUser.Any(x => x.Key == PersonNr && x.Value.AdminClearance == true); //Returnar en sann 
            return AdminClearance;
        }
    }
}

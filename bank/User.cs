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
        private string clearance;
        private int maxTries = 3;
        public string PersonNr { get => personNr; set => personNr = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Clearence { get => clearance; set => clearance = value; }

        private Dictionary<string, int> dPersonNr = new Dictionary<string, int>();
        private Dictionary<string, string> dUserPassword = new Dictionary<string, string>();
        private Dictionary<string, bool> dIsAdmin = new Dictionary<string, bool>();

        public User()
        {
            dPersonNr.Add("123456-4444", 1);
            dUserPassword.Add("123456-4444", "pass123");
            dIsAdmin.Add("123456-4444", true);


        }
        public bool ValidatePassword(string PersonNr, string PassWord)
        {
            return dUserPassword.Any(x => x.Key == PersonNr && x.Value == PassWord); //Returnar en sann 

        }


        public void UserInput()
        {
            Console.WriteLine("Skriv ditt användarnamn");
            var inputUName = Console.ReadLine();

            bool isValid;

            do //En loop som gör så du bara har 3 försök på dig för att logga in.
            {
                Console.WriteLine("Skriv in ditt lösenord");
                var inputUPass = Console.ReadLine();
                isValid = ValidatePassword(inputUName, inputUPass);
                maxTries--;
                Console.WriteLine(isValid ? "Du är inloggad" : "Gissat fel");
                if (maxTries >= 1)
                {
                    Console.WriteLine(maxTries + " Försök kvar");
                }

            }
            while (maxTries >= 1 && isValid == false);
        }
        public void CheckAdmin()// Kollar om isadmin har admin i sig. Början för att logga in som admin.
        {
            if (dIsAdmin.ContainsValue(true))
            {
                //Då är dom admin.
            }
        }
    }
}

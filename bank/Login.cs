using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace bank
{
    class Login
    {
        private Dictionary<string, int> userName = new Dictionary<string, int>();
        private Dictionary<string, string> userPassword = new Dictionary<string, string>();
        private Dictionary<string, bool> isAdmin = new Dictionary<string, bool>();
        private int maxTries = 3;
       
        public Login()
        {
            userName.Add("kenneth", 1);
            userPassword.Add("kenneth", "pass123");
            isAdmin.Add("kenneth", true);
            
        }
        public bool ValidatePassword(string username, string password)
        {
            return userPassword.Any(x => x.Key == username && x.Value == password); //Returnar en sann 

        }
       
        
        public void userInput()
        {
            Console.WriteLine("Skriv ditt användarnamn");
            var inputUName = Console.ReadLine();
            
            bool isValid;

            do //En loop som gör så du bara har 3 försök på dig för att logga in.
            {
                Console.WriteLine("Skriv ditt lösenord");
                var inputUPass = Console.ReadLine();
                isValid = ValidatePassword(inputUName, inputUPass);
                maxTries--;
                Console.WriteLine(isValid ? "Du är inloggad" : "Gissat fel");
                if(maxTries >= 1)
                {
                    Console.WriteLine(maxTries + " Försök kvarad");
                }
                
            }
            while (maxTries >= 1 && isValid == false);
        }
        public void CheckAdmin()// Kollar om isadmin har admin i sig. Början för att logga in som admin.
        {
            if (isAdmin.ContainsValue(true))
            {
                //Då är dom admin.
            }
        }
    }
}
        


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace bank
{
    class Login : Admin
    {
        
        
        private int maxTries = 3;
        public bool adminOut;
        

        public bool ValidatePassword(string username, string password)
        {
            return User.Any(x => x.Key == username && x.Value.UserPassword == password); //Returnar en sann 
            

        }
        public void IsUser()
        {
            User.Add("123", new UserInfo
            {
                UserPassword = "123",
                IsAdmin = true
            });
        }

        public void VerifyLogin()
        {
            Console.WriteLine("Skriv ditt Personnummer");
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
                    Console.WriteLine(maxTries + " Försök kvar");
                }
                
            }
            while (maxTries >= 1 && isValid == false);
        }
       
        public bool ValidateAdmin(string username, string password)
        {
          adminOut = User.Any(x => x.Key == username && x.Value.IsAdmin == true); //Returnar en sann 
          return adminOut;

        }
       
    }
}
        


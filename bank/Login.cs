using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace bank
{
    class Login : Admin
    {
        
        
        private int maxTries = 3;
        public bool clearance;



        public bool ValidatePassword(string personNr, string password)
        {
            return User.Any(x => x.Key == personNr && x.Value.passWord == password); //Returnar en sann 
            

        }
        public void DefaultUser()
        {
            User.Add("123", new UserInfo
            {
                passWord = "123",
                IsAdmin = true
            });
        }

        public void VerifyLogin()
        {
            
            clearance = false;
            Console.WriteLine("Skriv ditt Personnummer");
            var inputUName = Console.ReadLine();
            for (int i = 1; i < 100; i++)
            {
                
                

                if (User.ContainsKey(inputUName))
                {
                    Console.WriteLine("Ditt personnummer finns i systemet");
                    break;
                }
                else
                {
                    Console.WriteLine("Vi hittar inte ditt personnummer i systemet vänligen försök igen");
                    inputUName = Console.ReadLine();

                }
            }
                
            
               
            
            
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
          clearance = User.Any(x => x.Key == username && x.Value.IsAdmin == true); //Returnar en sann 
          return clearance;

        }
       
    }
}
        


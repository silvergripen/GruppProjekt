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
        public Login()
        {
            userName.Add("kenneth", 1);
            userPassword.Add("kenneth", "pass123");
            isAdmin.Add("kenneth", true);
        }
        public bool ValidatePassword(string username, string password)
        {
            return userPassword.Any(x => x.Key == username && x.Value == password);

        }
        public void userInput()
        {
            Console.WriteLine("Skriv ditt användarnamn");
            var inputUName = Console.ReadLine();
            Console.WriteLine("Skriv ditt lösenord");
            var inputUPass = Console.ReadLine();
            var isValid = ValidatePassword(inputUName, inputUPass);
            Console.WriteLine(isValid? "Du är inloggad" : "Gissat fel");
        }

    }
}

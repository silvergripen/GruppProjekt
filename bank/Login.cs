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
            userName.Add("Kenneth", 1);
            userPassword.Add("Kenneth", "Pass123");
            isAdmin.Add("Kenneth", true);
        }
        public bool ValidatePassword(string username, string password)
        {
            return userPassword.Any(x => x.Key == username && x.Value == password);

        }
    }
}

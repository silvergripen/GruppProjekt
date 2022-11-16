using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class User
    {
        private string passWord;
        private string personNr;
        public string PassWord { get; set; }
        public string PersonNr { get; set; }

        // Bättre att ha login som metoder inne i user?
        public bool Login()
        {
            bool loggedIn = false;
            return loggedIn;
        }
    }
}

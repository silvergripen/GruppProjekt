using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class User
    {
        private string userName;
        private string passWord;
        private int personNr;
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int PersonNr { get; set; }

        // Bättre att ha login som metoder inne i user?
        public bool Login()
        {
            bool loggedIn = false;
            return loggedIn;
        }
    }
}

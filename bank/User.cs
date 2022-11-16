using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class User
    {
        private string passWord;
        private string personNr;
        private string clearance;
        public string PersonNr { get; set; }
        public string PassWord { get; set; }
        public string Clearence { get; set; }

        // Bättre att ha login som metoder inne i user?
        // Ja, det tror jag. /Amie
        // Okay vill bara testa detta att redigera direkt i Git. /Madde
        public bool Login()
        {
            bool loggedIn = false;
            return loggedIn;
        }
    }
}

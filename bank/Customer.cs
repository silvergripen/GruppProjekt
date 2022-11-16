using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Customer : User
    {
        public string clearance = "User";
        public Customer(string aUsername, string aPassword, int aPersonNr, string aclearance)
        {
            this.UserName = aUsername;
            this.PassWord = aPassword;
            this.PersonNr = aPersonNr;
            this.clearance = aclearance;

        }
    }
}

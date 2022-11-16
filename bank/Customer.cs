using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Customer : User
    {
        public string clearance = "User";
        public Customer(string aPersonNr, string aPassword, string aclearance)
        {
            this.PassWord = aPassword;
            this.PersonNr = aPersonNr;
            this.clearance = aclearance;

        }
    }
}

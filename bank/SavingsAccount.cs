using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class SavingsAccount : Account
    {
        private double SavingsRate = 2;

        public string NewSavingsAccount(string personNr)
        {
            User userClass = new User();
            userClass.PersonNr = personNr;
            string savingsAccount = "1-1";
            return $"{clearingNr}, {personNr}-{savingsAccount}";
        }
    }
}

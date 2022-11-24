using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class SavingsAccount : Account
    {
        private double SavingsRate = 2;
        public SavingsAccount(double aAccountBalance)
        {
            this.clearingNr = "9874-5";
            this.AccountBalance = accountBalance;
            aAccountBalance = 0;
        }
        public string NewSavingsAccount(string personNr)
        {
            User userClass = new User();
            userClass.PersonNr = personNr;
            string savingsAccount = "1-1";
            return $"{clearingNr}, {personNr}-{savingsAccount}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class SavingsAccount : Account
    {
        private double savingsRate = 2;
        public SavingsAccount(double aAccountBalance)
        {
            this.clearingNr = "9874-5";
            this.AccountBalance = aAccountBalance;
        }
        public string NewSavingsAccount(string aPersonNr)
        {
            Customer customer = new Customer();
            customer.PersonNr = aPersonNr;
            string savingsAccount = "1-1";
            return $"{clearingNr}, {aPersonNr}-{savingsAccount} \t{AccountBalance} kr\t{savingsRate} %";
        }
    }
}

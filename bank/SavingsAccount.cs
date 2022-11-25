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
            this.AccountBalance = aAccountBalance;
        }
        public string NewSavingsAccount(string aPersonNr)
        {
            Customer customer = new Customer();
            customer.PersonNr = aPersonNr;
            string savingsAccount = "1-1";
            return $"{clearingNr}, {aPersonNr}-{savingsAccount}, Balance: {AccountBalance} kr, Savings Rate: {SavingsRate} %";
        }
    }
}

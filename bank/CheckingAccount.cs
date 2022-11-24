using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class CheckingAccount : Account
    {
        public CheckingAccount(double aAccountBalance)
        {
            this.clearingNr = "9874-5";
            this.AccountBalance = aAccountBalance;
        }
        public string NewCheckingAccount(string personNr)
        {
            Customer customer = new Customer();
            string CheckingAccount = "1";
            customer.PersonNr = personNr;
            return $"{clearingNr}, {personNr}-{CheckingAccount}, Balance: ${accountBalance}";
        }
    }
}

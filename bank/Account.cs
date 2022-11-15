using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Account
    {
        float balance;
        float interest;
        int newAccount;


        private float Balance()
        {

            return balance;
        }
        private float Interest()
        {

            return interest;
        }
        private int NewAccount()
        {
            return newAccount;
        }
        private void SavingsAccount()
        {

        }
        private void Loan(float loan)
        {

            if (loan >= 5*balance)
            {
                Console.WriteLine("Sorry, you're not allowed to take out this loan");
            }
            else
            {
                Console.WriteLine("Approved!");
            }
        }
    }
}

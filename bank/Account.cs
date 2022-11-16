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

        
        public float Balance()
        {
            Random rand = new Random();
            balance = rand.Next(0, 100000);
            return balance;
        }
        //private float Interest()
        //{

        //    return interest;
        //}
        //private int NewAccount()
        //{
        //    newAccount = user1.personNr;
        //    return newAccount;
        //}
        //private void SavingsAccount()
        //{

        //}
        //private void Loan(float loan)
        //{

        //    if (loan >= 5*balance)
        //    {
        //        Console.WriteLine("Sorry, you're not allowed to take out this loan");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Approved!");
        //    }
        //}
    }
}

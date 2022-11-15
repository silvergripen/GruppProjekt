using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    interface IAccount
    {
        float Balance();
        float Interest();
        int NewAccount();
        void SavingsAccount();
        void Loan(float loan); //Hejhej-Amie
    }
}

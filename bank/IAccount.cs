using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    interface IAccount
    {
        public string Account1(string personNr);
        public string Account2(string personNr);
        public string Account3(string personNr);
        public string Account4(string personNr);
        public string SavingsAccount1(string personNr);
        public double Balance(string accountNr);
        public string Overview(string accountNr);
        public string AccountStatement(string accountNr);
        public double InterestRate();
        public double ExchangeRate();
        public void ChangeCurrency();
    }
}

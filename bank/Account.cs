using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Account 
    {
        public readonly string clearingNr = "9874-5";
        private string accountNr;
        private double accountBalance;
        private double defaultCurrency_SEK = 1;
        public string AccountNr { get => accountNr; set => accountNr = value; }
        public double AccountBalance { get => accountBalance; set => accountBalance = value; }
        public double DefaultCurrency_SEK { get => defaultCurrency_SEK; set => defaultCurrency_SEK = value; }


        public void AccountStatement()
        {
            
        }

        public double Balance(string personNr, string accountNr)
        {
            return AccountBalance;
        }

        public void Overview()
        {
            
        }

        public void InterestRate()
        {

        }
        public void ExchangeRate()
        {

        }
        public void ChangeCurrency()
        {

        }
        
    }
}

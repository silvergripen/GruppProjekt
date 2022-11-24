using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Account
    {
        public string displayInformation { get; set; }
        protected string clearingNr;
        //private string accountNr;
        protected double accountBalance;
        protected double defaultCurrency_SEK = 1;
        //public string AccountNr { get => accountNr; set => accountNr = value; }
        public double AccountBalance { get => accountBalance; set => accountBalance = value; }
        public double DefaultCurrency_SEK { get => defaultCurrency_SEK; set => defaultCurrency_SEK = value; }

        public double Balance(string accountNr)
        {
            return AccountBalance;
        }
        
    }
}

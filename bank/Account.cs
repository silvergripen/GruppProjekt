using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Account
    {
        public string displayInformation { get; set; }
        protected string clearingNr;
        protected double accountBalance;
        public double AccountBalance { get => accountBalance; set => accountBalance = value; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    interface IAccount
    {
        protected double Balance(); //Ocks
        public abstract double GetInterestrate(); //Metod som overridas i <<Cheking(Bank)Account>> för <<minus interest rate (kostnad för kund)>> och <<plus>> intrerest rate i <<SavingAccount>>
    }
}

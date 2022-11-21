using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    interface ICustomer
    {
        public void AddAccount();
        public void AddSavingsAccount();
        public void TakeLoan();
        public void ListOfAccounts();
        public void TransferMyAccounts();
        public void TransferOtherAccounts();
        public void OverviewAllAccounts();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank
{
    class Admin : User
    {
        public string Clearance = "admin";

        public void AddCustomer()
        {
            Console.WriteLine("Here you can add a customer, please press enter to go back");
            Console.ReadKey();
        }
        public void ChangeExchangeRate()
        {
            Console.WriteLine("Here you can change the exchange rates, please press enter to go back");
            Console.ReadKey();
        }
    }
}

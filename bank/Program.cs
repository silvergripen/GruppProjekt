using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            Console.WriteLine("Whats your personnr:");
            string personNr = Console.ReadLine();
            cust.AddAccount(personNr);

            //Application application = new Application();
            //application.LoginScreen();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Admin : User
    {
        public string clearance = "Admin";
        public Admin()
        {
            //if (aclearance == "Admin")
            //{
            //    Console.WriteLine("You have access to admin services");
            //}
            //else
            //{
            //    Console.WriteLine("You nedd to be admin to reach these services");
            //}
        }
        public void CreateCustomer()
        {
            Console.WriteLine("New personnr:");
            string personNr = Console.ReadLine();
            Console.WriteLine("New password:");
            string password = Console.ReadLine();
            Console.WriteLine("Users clearance:");
            string clearance = Console.ReadLine();
            Customer C1 = new Customer(personNr, password, clearance);
            Console.WriteLine($"{C1.PersonNr} {C1.PassWord} {C1.clearance}");

        }
    }
}

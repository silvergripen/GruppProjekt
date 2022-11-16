using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Admin : User
    {
        public string clearance = "Admin";
        public Admin(string aclearance)
        {
            if (aclearance == "Admin")
            {
                Console.WriteLine("You have access to admin services");
            }
            else
            {
                Console.WriteLine("You nedd to be admin to reach these services");
            }
        }
    }
}

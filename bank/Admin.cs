using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Admin : User
    {
        //public string clearance = "Admin";
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
            Console.Clear();
            Console.WriteLine("New password:");
            string password = Console.ReadLine();

            string prompt = "User clearance: \n(Use the arrow keys to cycle through options and press Enter to select.";
            string[] options = { "Admin", "User" };
            Menu createNewUserMenu = new Menu(prompt, options);
            int MenuSelect = createNewUserMenu.Run();

            if (MenuSelect == 0)
            {
                Console.Clear();
                string clearance = "admin";
                Customer C1 = new Customer(personNr, password);
                Console.WriteLine($"{C1.PersonNr} {C1.PassWord} {clearance}");
            }
            else if (MenuSelect == 1)
            {
                Console.Clear();
                string clearance = "user";
                Customer C1 = new Customer(personNr, password);
                Console.WriteLine($"You have created a new user: Personnr: {C1.PersonNr} Password: {C1.PassWord} Clearence: {clearance}");
            }
            

        }
    }
}

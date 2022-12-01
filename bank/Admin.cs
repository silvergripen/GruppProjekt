using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank
{
    class Admin : User
    {
        private string inputPersNm;
        private string inputPass;
        public string InputPersNm
        {
            get => inputPersNm;
            set
            {
                if (value.Length == 11)
                {
                    inputPersNm = value;
                }
                else if (value.Length < 11)
                {
                    Console.WriteLine("Sorry, the social security number is too short.");
                    AddCustomer();
                }
                else
                {
                    Console.WriteLine("Sorry, the social security number is too long.");
                    AddCustomer();
                }
            }
        }
        public void AddCustomer()
        {
            Console.WriteLine("Please enter the social security number of the customer you want to add (YYMMDD-NNNN):");
            InputPersNm = Console.ReadLine();
            Console.WriteLine("Please enter the password you want to create for the customer:");
            inputPass = Console.ReadLine();
            userList.Add(new Customer
            {
                PersonNr = inputPersNm,             
                PassWord = inputPass,
                AdminClearance = false
            });
        }
    }
}

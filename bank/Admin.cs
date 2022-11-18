using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    abstract class Admin : UserInfo
    {
        public Dictionary<string, UserInfo> User = new Dictionary<string, UserInfo>();
        string inputPersNm;
        string inputPass;
        public void AddCustomer()
        {
            Console.WriteLine("Vad är personnummeret på personen som du vill lägga till?");
          inputPersNm = Console.ReadLine();
            Console.WriteLine("Vilket lösenord vill du ge till personen som ska logga in?");
          inputPass = Console.ReadLine();
            User.Add(inputPersNm, new UserInfo
            {
                passWord = inputPass,
                IsAdmin = false
            });
            
        }
        public void 
    }

}

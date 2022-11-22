using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank
{
    class Admin : User
    {
        string inputPersNm;
        string inputPass;
   
        public void AddCustomer()
        {
            Console.WriteLine("Vad är personnummeret på personen som du vill lägga till?");
            inputPersNm = Console.ReadLine();
            Console.WriteLine("Vilket lösenord vill du ge till personen som ska logga in?");
            inputPass = Console.ReadLine();
            dictUser.Add(inputPersNm = PersonNr, new User
            {
                PersonNr = inputPersNm,
                PassWord = inputPass,
                AdminClearance = false
            });
            
            //Console.WriteLine("Here you can change the exchange rates, please press enter to go back");
            //Console.ReadKey();
        }
        //public void ChangeExchangeRate()
        //{
        //    Console.WriteLine("Vad ligger Euron på nu?");
        //    input = Console.ReadLine();
        //    tempValue = double.Parse(input, double);
        //    dictExchangeRate["EUR"] = input;
        //}
    }

}

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
            Console.WriteLine("Please enter the social security number of the customer you want to add:");
            inputPersNm = Console.ReadLine();
            Console.WriteLine("Please enter the password you want to create for the customer:");
            inputPass = Console.ReadLine();
            dictUser.Add(inputPersNm, new User
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

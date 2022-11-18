using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Account 
    {
        protected readonly string clearingNr = "9874-5";
        private string accountNr;
        private double accountBalance;
        private double defaultCurrency_SEK = 1;
        public string AccountNr { get => accountNr; set => accountNr = value; }
        public double AccountBalance { get => accountBalance; set => accountBalance = value; }
        public double DefaultCurrency_SEK { get => defaultCurrency_SEK; set => defaultCurrency_SEK = value; }


        public void AccountStatement()
        {
            throw new NotImplementedException();
        }

        public double Balance(string personNr, string accountNr)
        {
            return AccountBalance;
        }

        public void Overview()
        {
            throw new NotImplementedException();
        }

        public void InterestRate(string personNr)
        {

        }
        public void ExchangeRate(double defaultCurrency_SEK)
        {
//            this.defaultCurrency_SEK = defaultCurrency_SEK;
//            Dictionary<string, double> dictExchangeRate = new Dictionary<string, double>();
//            dictExchangeRate.Add("EUR", 0.091);
//            dictExchangeRate.Add("USD", 0.094);
//            dictExchangeRate.Add("DKK", 0.68);
//            dictExchangeRate.Add("NOK", 0.95);
//            dictExchangeRate.Add("ISK", 13.51);

            
//            application.Logo();
//            string prompt = @"
//Welcome to the current exchange rates.
//Choose which currency you want to update
//(Use the arrow keys to cycle through options and press Enter to select.";
//            string[] options = { "EUR", "USD", "DKK", "NOK", "ISK" };
//            Menu mainMenu = new Menu(prompt, options);
//            int menuSelect = mainMenu.Run();

//            switch (menuSelect)
//            {
//                case 0:
//                    Console.WriteLine($"");
//                    break;
//                case 1:
//                    Console.WriteLine($"");
//                    break;
//                case 2:
//                    Console.WriteLine($"");
//                    break;
//                case 3:
//                    Console.WriteLine($"");
//                    break;
//                case 4:
//                    Console.WriteLine($"");
//                    break;
//            }
//            switch (currency.ToUpper())
//            {
//                case "EUR":
                    
//                    break;
//                case "USD":

//                    break;
//                case "DKK":

//                    break;
//                case "NOK":

//                    break;
//                case "ISK":

//                    break;
//            }
        }
        public string Account1(string personNr)
        {
            User userClass = new User();
            string savingsAccount1 = "1";
            userClass.PersonNr = personNr;
            return $"{clearingNr}, {personNr}-{savingsAccount1}";
        }

        public string Account2(string personNr)
        {
            User userClass = new User();
            string savingsAccount2 = "2";
            userClass.PersonNr = personNr;
            return $"{clearingNr}, {personNr}-{savingsAccount2}";
        }

        public string Account3(string personNr)
        {
            User userClass = new User();
            string savingsAccount3 = "3";
            userClass.PersonNr = personNr;
            return $"{clearingNr}, {personNr}-{savingsAccount3}";
        }

        public string Account4(string personNr)
        {
            User userClass = new User();
            string savingsAccount4 = "4";
            userClass.PersonNr = personNr;
            return $"{clearingNr}, {personNr}-{savingsAccount4}";
        }
        
    }
}

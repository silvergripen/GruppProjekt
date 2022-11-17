using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Account 
    {
        private double balance;
        //private double rate;
        private double SEKcurrency = 1;
        readonly User user = new User();
        readonly Application application = new Application();

        struct StructAccount
        {

        }
        public void AccountStatement()
        {
            throw new NotImplementedException();
        }

        public double Balance()
        {
            return balance;
        }

        public void Overview()
        {
            throw new NotImplementedException();
        }

        public string SavingsAccount1(string personNr)
        {
            string savingsAccount1 = "1-1";
            this.user._PersonNr = personNr;
            return $"{personNr}-{savingsAccount1}";
        }

        public void InterestRate(string personNr)
        {
            this.user._PersonNr = personNr;
            Dictionary<string, double> dictInterestRate = new Dictionary<string, double>();
            dictInterestRate.Add(SavingsAccount1(personNr), 2);
            dictInterestRate.Add(Account1(personNr), 0.1);
            dictInterestRate.Add(Account2(personNr), 0.1);
            dictInterestRate.Add(Account3(personNr), 0.1);
            dictInterestRate.Add(Account4(personNr), 0.1);
        }
        public void ExchangeRate(string currency)
        {

            Dictionary<string, double> dictExchangeRate = new Dictionary<string, double>();
            dictExchangeRate.Add("EUR", 0.091);
            dictExchangeRate.Add("USD", 0.094);
            dictExchangeRate.Add("DKK", 0.68);
            dictExchangeRate.Add("NOK", 0.95);
            dictExchangeRate.Add("ISK", 13.51);

            
            application.Logo();
            string prompt = @"
Welcome to the current exchange rates.
Choose which currency you want to update
(Use the arrow keys to cycle through options and press Enter to select.";
            string[] options = { "EUR", "USD", "DKK", "NOK", "ISK" };
            Menu mainMenu = new Menu(prompt, options);
            int menuSelect = mainMenu.Run();

            switch (menuSelect)
            {
                case 0:
                    Console.WriteLine($"");
                    break;
                case 1:
                    Console.WriteLine($"");
                    break;
                case 2:
                    Console.WriteLine($"");
                    break;
                case 3:
                    Console.WriteLine($"");
                    break;
                case 4:
                    Console.WriteLine($"");
                    break;
            }
            switch (currency.ToUpper())
            {
                case "EUR":
                    
                    break;
                case "USD":

                    break;
                case "DKK":

                    break;
                case "NOK":

                    break;
                case "ISK":

                    break;
            }
        }
        public string Account1(string personNr)
        {
            string savingsAccount1 = "1";
            this.user._PersonNr = personNr;
            return $"{personNr}-{savingsAccount1}";
        }

        public string Account2(string personNr)
        {
            string savingsAccount2 = "2";
            this.user._PersonNr = personNr;
            return $"{personNr}-{savingsAccount2}";
        }

        public string Account3(string personNr)
        {
            string savingsAccount3 = "3";
            this.user._PersonNr = personNr;
            return $"{personNr}-{savingsAccount3}";
        }

        public string Account4(string personNr)
        {
            string savingsAccount4 = "14";
            this.user._PersonNr = personNr;
            return $"{personNr}-{savingsAccount4}";
        }
    }
}

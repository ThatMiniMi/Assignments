using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_constructors
{
        class Program
        {
            static void Main(string[] args)
            {
                CurrencyConverter converter = new CurrencyConverter(0.095m, 0.085m, 1m);
                Money myMoney = new Money(1000m, Currency.SEK);

                myMoney.ChangeCurrency(converter, Currency.Dollar);
                Console.WriteLine($"Converted Amount: {myMoney.Amount:F2} {myMoney.Currency}");
                myMoney.ChangeCurrency(converter, Currency.Euro);
                Console.WriteLine($"Converted Amount: {myMoney.Amount:F2} {myMoney.Currency}");

                Account myAccount = new Account
                {
                    Balance = new Money(500m, Currency.SEK),
                    Id = 12345
                };

                Console.WriteLine($"Account ID: {myAccount.Id}, Balance: {myAccount.Balance.Amount:F2} {myAccount.Balance.Currency}");

                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
            }
        }
    }


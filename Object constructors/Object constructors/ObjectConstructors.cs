using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_constructors
{
    // Money
    public class Money
    {
        public decimal Amount { get; private set; }
        public Currency Currency { get; private set; }
        public Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }
        public void ChangeCurrency(CurrencyConverter converter, Currency newCurrency)
        {
            switch (Currency)
            {
                case Currency.Dollar:
                    switch (newCurrency)
                    {
                        case Currency.Euro:
                            Amount = converter.ConvertDollarToEuro(Amount);
                            break;
                        case Currency.SEK:
                            Amount = converter.ConvertDollarToSEK(Amount);
                            break;
                        default:
                            break; // No conversion needed
                    }
                    break;

                case Currency.Euro:
                    switch (newCurrency)
                    {
                        case Currency.Dollar:
                            Amount = converter.ConvertEuroToDollar(Amount);
                            break;
                        case Currency.SEK:
                            Amount = converter.ConvertEuroToSEK(Amount);
                            break;
                        default:
                            break; // No conversion needed
                    }
                    break;

                case Currency.SEK:
                    switch (newCurrency)
                    {
                        case Currency.Dollar:
                            Amount = converter.ConvertSEKToDollar(Amount);
                            break;
                        case Currency.Euro:
                            Amount = converter.ConvertSEKToEuro(Amount);
                            break;
                        default:
                            break; // No conversion needed
                    }
                    break;
            }
            Currency = newCurrency;
        }
    }
    // Currency Converter
    public class CurrencyConverter
    {
        public decimal Dollar { get; private set; }
        public decimal Euro { get; private set; }
        public decimal SEK { get; private set; }
        public CurrencyConverter(decimal dollarRate, decimal euroRate, decimal sekRate)
        {
            Dollar = dollarRate;
            Euro = euroRate;
            SEK = sekRate;
        }
        public decimal ConvertDollarToEuro(decimal dollar) => dollar * (Euro / Dollar);
        public decimal ConvertDollarToSEK(decimal dollar) => dollar * (SEK / Dollar);
        public decimal ConvertEuroToDollar(decimal euro) => euro * (Dollar / Euro);
        public decimal ConvertEuroToSEK(decimal euro) => euro * (SEK / Euro);
        public decimal ConvertSEKToDollar(decimal sek) => sek * (Dollar / SEK);
        public decimal ConvertSEKToEuro(decimal sek) => sek * (Euro / SEK);
    }
    // Account
    public class Account
    {
        public Money Balance { get; set; }
        public int Id { get; set; }
    }
}

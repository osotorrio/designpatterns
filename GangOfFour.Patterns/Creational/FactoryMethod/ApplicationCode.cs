using GangOfFour.Patterns.Creational.FactoryMethod.Creators;
using GangOfFour.Patterns.Creational.FactoryMethod.Products;
using System;
using System.Collections.Generic;
using Xunit;

namespace GangOfFour.Patterns.Creational.FactoryMethod
{
    public class ApplicationCode
    {
        private Dictionary<string, AbstractBanknoteCreator> _creators => new Dictionary<string, AbstractBanknoteCreator>
        {
            {"EUR", new EuroBanknoteCreator()},
            {"WON", new WonBanknoteCreator() }
        };

        [Theory]
        [InlineData("EUR")]
        [InlineData("WON")]
        public void ExampleFactoryMethodPattern(string currencyCode)
        {
            if (_creators.ContainsKey(currencyCode))
            {
                var banknoteCreator = _creators[currencyCode];
                banknoteCreator.CreateBanknotesFactoryMethod();
                PrintOut(banknoteCreator.Banknotes);
            }
            else
            {
                throw new ArgumentException("The currency code is not known by the system");
            }
        }

        private static void PrintOut(List<AbstractBanknoteProduct> banknotes)
        {
            banknotes.ForEach(banknote => banknote.ToString());
        }
    }
}

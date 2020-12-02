using GangOfFour.Patterns.Creational.FactoryMethod.Creators;
using GangOfFour.Patterns.Creational.FactoryMethod.Products;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;
using System;
using Xunit;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Client
{
    public class Application
    {
        [Theory]
        [InlineData(Countries.ES, AccountTypes.Business, "Jesus Sanchez", 500.00)]
        [InlineData(Countries.FR, AccountTypes.Standard, "Leroy Leblanc", 700.00)]
        public void CodeBeforePattern(Countries userInputCountry, AccountTypes userInputAccountType, string userInputName, decimal userInputAmount)
        {
            IBankAccount account = null;

            if (Countries.ES == userInputCountry)
            {
                switch (userInputAccountType)
                {
                    case AccountTypes.Standard:
                        account = new StandardAccountSpain();
                        break;
                    case AccountTypes.Business:
                        account = new BusinessAccountSpain();
                        break;
                    default:
                        throw new Exception("Unknown account type");
                }
            }

            if (Countries.FR == userInputCountry)
            {
                var creditCheck = new CreditCheck();

                switch (userInputAccountType)
                {
                    case AccountTypes.Standard:
                        account = new StandardAccountFrance(creditCheck);
                        break;
                    case AccountTypes.Business:
                        account = new BusinessAccountFrance(creditCheck);
                        break;
                    default:
                        throw new Exception("Unknown account type");
                }
            }

            account.OpenAccount(userInputName);
            account.CreditAccount(userInputAmount);
        }

        [Theory]
        [InlineData(Countries.ES, AccountTypes.Business, "Jesus Sanchez", 500.00)]
        [InlineData(Countries.FR, AccountTypes.Standard, "Leroy Leblanc", 700.00)]
        public void CodeAfterPattern(Countries userInputCountry, AccountTypes userInputAccountType, string userInputName, decimal userInputAmount)
        {
            BanckAccountFactory factory = null;

            if (Countries.ES == userInputCountry)
            {
                factory = new BankAccountSpainFactory();
            }

            if (Countries.FR == userInputCountry)
            {
                var creditCheck = new CreditCheck();
                factory = new BankAccountFranceFactory(creditCheck);
            }

            var account = factory.CreateBankAccountObject(userInputAccountType);

            account.OpenAccount(userInputName);
            account.CreditAccount(userInputAmount);
        }
    }
}

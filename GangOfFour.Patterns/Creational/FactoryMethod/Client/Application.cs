using GangOfFour.Patterns.Creational.FactoryMethod.Creators;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;
using Xunit;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Client
{
    public class Application
    {
        /// <summary>
        /// In a real application the responsability to decide which factory (or branch) to be created could be delegated to an IoC container
        /// </summary>
        [Theory]
        [InlineData(Countries.ES, AccountTypes.Business, "Jesus Sanchez", 500.00)]
        [InlineData(Countries.FR, AccountTypes.Standard, "Leroy Leblanc", 700.00)]
        public void ExampleFactoryMethodPattern(Countries userInputCountry, AccountTypes userInputAccountType, string userInputName, decimal userInputAmount)
        {
            DefaultBranch branch = null;

            if (Countries.ES == userInputCountry)
            {
                branch = new SpanishBranch();
            }

            if (Countries.FR == userInputCountry)
            {
                var creditCheck = new CreditCheck();
                branch = new FrenchBranch(creditCheck);
            }

            branch.OpenBankAccount(userInputAccountType, userInputName, userInputAmount);
        }
    }
}

using GangOfFour.Patterns.Creational.FactoryMethod.Creators;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;
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
            var creditCheck = new CreditCheck();
            var branch = new BranchBeforePattern(creditCheck, userInputCountry);
            branch.OpenBankAccount(userInputAccountType, userInputName, userInputAmount);
        }

        /// <summary>
        /// Interesting enough, the application code gets more complex after applying the pattern.
        /// In a real application the responsability to decide which factory to create would be delegated to an IoC container.
        /// In this way, the application code would be almost the same before and after implementing the pattern.
        /// </summary>
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

            var branch = new BranchAfterPattern(factory);
            branch.OpenBankAccount(userInputAccountType, userInputName, userInputAmount);
        }
    }
}

using GangOfFour.Patterns.Creational.FactoryMethod.Creators;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;
using System.Collections.Generic;
using Xunit;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Client
{
    public class Application
    {
        /// <summary>
        /// The application only knows it gets injected an abstract branch and some input parameters.
        /// </summary>
        
        [Theory]
        [MemberData(nameof(InjectDependencies))]
        public void ExampleFactoryMethodPattern(AbstractBranch branch, AccountTypes accountType, string holder, decimal amount)
        {
            branch.OpenBankAccount(accountType, holder, amount);
        }

        public static IEnumerable<object[]> InjectDependencies()
        {
            var creditCheck = new CreditCheck();

            return new List<object[]>
            {
                new object[] { new SpanishBranch(), AccountTypes.Business, "Jesus Sanchez", 500.00 },
                new object[] { new FrenchBranch(creditCheck), AccountTypes.Standard, "Leroy Leblanc", 700.00 }
            };
        }
    }
}

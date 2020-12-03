using GangOfFour.Patterns.Creational.FactoryMethod.Products;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Creators
{
    public class FrenchBranch : DefaultBranch
    {
        private readonly IRunCreditChecks _creditCheck;

        public FrenchBranch(IRunCreditChecks creditCheck)
        {
            _creditCheck = creditCheck;
        }

        public override IBankAccount CreateBankAccount(AccountTypes accountType)
        {
            if (AccountTypes.Business == accountType)
            {
                return new BusinessAccountFrance(_creditCheck);
            }

            if (AccountTypes.Standard == accountType)
            {
                return new StandardAccountFrance(_creditCheck);
            }

            throw new ArgumentException($"Unknown account type {accountType}", nameof(accountType));
        }
    }
}

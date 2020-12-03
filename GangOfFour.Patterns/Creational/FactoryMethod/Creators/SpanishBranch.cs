using GangOfFour.Patterns.Creational.FactoryMethod.Products;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Creators
{
    public class SpanishBranch : DefaultBranch
    {
        public override IBankAccount CreateBankAccount(AccountTypes accountType)
        {
            if (AccountTypes.Business == accountType)
            {
                return new BusinessAccountSpain();
            }

            if (AccountTypes.Standard == accountType)
            {
                return new StandardAccountSpain();
            }

            throw new ArgumentException($"Unknown account type {accountType}", nameof(accountType));
        }
    }
}

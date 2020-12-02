using GangOfFour.Patterns.Creational.FactoryMethod.Products;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Creators
{
    public class BankAccountFranceFactory : BanckAccountFactory
    {
        private readonly IRunCreditChecks _creditCheck;

        public BankAccountFranceFactory(IRunCreditChecks creditCheck)
        {
            _creditCheck = creditCheck;
        }

        public override IBankAccount CreateBankAccountObject(AccountTypes accountType)
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

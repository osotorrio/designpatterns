using GangOfFour.Patterns.Creational.FactoryMethod.Products;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Client
{
    public class BranchBeforePattern : IBranch
    {
        private readonly Countries _country;

        public BranchBeforePattern(Countries country)
        {
            _country = country;
        }

        public void OpenBankAccount(AccountTypes type, string holder, decimal amount)
        {
            IBankAccount account = null;

            if (Countries.ES == _country)
            {
                switch (type)
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

            if (Countries.FR == _country)
            {
                var creditCheck = new CreditCheck();

                switch (type)
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

            account.OpenAccount(holder);
            account.CreditAccount(amount);
        }
    }
}

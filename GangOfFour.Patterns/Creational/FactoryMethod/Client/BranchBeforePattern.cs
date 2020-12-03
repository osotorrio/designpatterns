using GangOfFour.Patterns.Creational.FactoryMethod.Products;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Client
{
    /// <summary>
    /// This class has 3 responsabilities:
    /// 1- It knows how to open an account calling OpenAccount() and CreditAccount()
    /// 2- It knows which type of account has to be created. Business or Standard.
    /// 3- It also knows that accounts created in France need to run a credit check.
    /// </summary>
    public class BranchBeforePattern : IBranch
    {
        private readonly IRunCreditChecks _creditCheck;
        private readonly Countries _country;

        public BranchBeforePattern(IRunCreditChecks creditCheck, Countries country)
        {
            _country = country;
            _creditCheck = creditCheck;
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
                switch (type)
                {
                    case AccountTypes.Standard:
                        account = new StandardAccountFrance(_creditCheck);
                        break;
                    case AccountTypes.Business:
                        account = new BusinessAccountFrance(_creditCheck);
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

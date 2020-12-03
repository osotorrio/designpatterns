using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    public class StandardAccountFrance : IBankAccount
    {
        private readonly IRunCreditChecks _creditCheck;

        public StandardAccountFrance(IRunCreditChecks creditCheck)
        {
            _creditCheck = creditCheck;
        }

        public Guid AccountId => Guid.NewGuid();

        public void CreditAccount(decimal amount)
        {
            /*
                Here the code to increase the balance of the account. For instance:

                repository.UpdateBalance(AccountId, amount);
             */
        }

        public bool OpenAccount(string holder)
        {
            var isHolderTrustable = _creditCheck.CheckHolder(holder);

            if (isHolderTrustable)
            {
                /*
                    Here the code to register a new bank account with the holder name. For instance:

                    repository.Save(AccountId, holder);
                 */
            }

            return isHolderTrustable;
        }
    }
}

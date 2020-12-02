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

        public void CreditAccount(decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool OpenAccount(params string[] holders)
        {
            throw new NotImplementedException();
        }
    }
}

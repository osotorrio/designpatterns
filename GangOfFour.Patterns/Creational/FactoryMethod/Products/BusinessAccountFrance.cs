using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    public class BusinessAccountFrance : IBankAccount
    {
        private readonly IRunCreditChecks _creditCheck;

        public BusinessAccountFrance(IRunCreditChecks creditCheck)
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

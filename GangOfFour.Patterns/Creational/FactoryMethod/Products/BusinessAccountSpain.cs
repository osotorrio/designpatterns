using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    public class BusinessAccountSpain : IBankAccount
    {
        public void CreditAccount(decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool OpenAccount(string holder)
        {
            throw new NotImplementedException();
        }
    }
}

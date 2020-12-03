using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    public class StandardAccountSpain : IBankAccount
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

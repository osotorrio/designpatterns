using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    public interface IBankAccount
    {
        Guid AccountId { get; }

        bool OpenAccount(string holder);

        void CreditAccount(decimal amount);
    }
}

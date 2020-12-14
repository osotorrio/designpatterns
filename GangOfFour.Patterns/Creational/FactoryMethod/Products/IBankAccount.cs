using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    /// <summary>
    /// Abstract Product
    /// </summary>
    public interface IBankAccount
    {
        Guid AccountId { get; }

        bool OpenAccount(string holder);

        void CreditAccount(decimal amount);
    }
}

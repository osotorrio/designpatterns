using GangOfFour.Patterns.Creational.FactoryMethod.Products;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Creators
{
    /// <summary>
    /// Abstract Creator
    /// </summary>
    public abstract class AbstractBranch
    {
        public void OpenBankAccount(AccountTypes type, string holder, decimal amount)
        {
            var account = CreateBankAccount(type);
            account.OpenAccount(holder);
            account.CreditAccount(amount);
        }

        public abstract IBankAccount CreateBankAccount(AccountTypes accountType);
    }
}

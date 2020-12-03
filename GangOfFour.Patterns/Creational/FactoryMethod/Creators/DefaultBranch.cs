using GangOfFour.Patterns.Creational.FactoryMethod.Products;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Creators
{
    /// <summary>
    /// DefaultBranch creator knows how to open a bank account. By first calling OpenAccount() and then CreditAccount().
    /// This class allows its children to decide which type of account would be created.
    /// </summary>
    public abstract class DefaultBranch
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

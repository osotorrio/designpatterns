using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Client
{
    public interface IBranch
    {
        public void OpenBankAccount(AccountTypes type, string holder, decimal amount);
    }
}
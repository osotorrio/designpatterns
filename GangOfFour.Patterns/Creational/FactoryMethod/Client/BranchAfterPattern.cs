using GangOfFour.Patterns.Creational.FactoryMethod.Creators;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Client
{
    public class BranchAfterPattern
    {
        private readonly BanckAccountFactory _factory;

        public BranchAfterPattern(BanckAccountFactory factory)
        {
            _factory = factory;
        }

        public void OpenBankAccount(AccountTypes type, string holder, decimal amount)
        {
            var account = _factory.CreateBankAccountObject(type);
            account.OpenAccount(holder);
            account.CreditAccount(amount);
        }
    }
}

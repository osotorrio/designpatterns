using GangOfFour.Patterns.Creational.FactoryMethod.Products;
using GangOfFour.Patterns.Creational.FactoryMethod.Stuff;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Creators
{
    public abstract class BanckAccountFactory
    {
        public abstract IBankAccount CreateBankAccountObject(AccountTypes accountType);
    }
}

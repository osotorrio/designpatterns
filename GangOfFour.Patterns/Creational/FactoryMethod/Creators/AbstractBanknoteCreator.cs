using GangOfFour.Patterns.Creational.FactoryMethod.Products;
using System.Collections.Generic;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Creators
{
    public abstract class AbstractBanknoteCreator
    {
        public List<AbstractBanknoteProduct> Banknotes { get; private set; }

        public abstract void CreateBanknotesFactoryMethod();
    }
}

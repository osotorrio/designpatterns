using GangOfFour.Patterns.Creational.FactoryMethod.Products;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Creators
{
    public class EuroBanknoteCreator : AbstractBanknoteCreator
    {
        public override void CreateBanknotesFactoryMethod()
        {
            Banknotes.Add(new FiveEuroBanknoteProduct());
            Banknotes.Add(new TenEuroBanknoteProduct());
            Banknotes.Add(new TwentyEuroBanknoteProduct());
            Banknotes.Add(new FittyEuroBanknoteProduct());
            Banknotes.Add(new OneHundredEuroBanknoteProduct());
            Banknotes.Add(new TwoHundredEuroBanknoteProduct());
        }
    }
}

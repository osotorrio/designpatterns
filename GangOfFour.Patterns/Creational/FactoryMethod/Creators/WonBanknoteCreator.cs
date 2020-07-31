using GangOfFour.Patterns.Creational.FactoryMethod.Products;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Creators
{
    public class WonBanknoteCreator : AbstractBanknoteCreator
    {
        public override void CreateBanknotesFactoryMethod()
        {
            Banknotes.Add(new OneThounsandWonBankNoteProduct());
            Banknotes.Add(new FiveThounsandWonBankNoteProduct());
            Banknotes.Add(new TenThounsandWonBankNoteProduct());
            Banknotes.Add(new FiveThounsandWonBankNoteProduct());
        }
    }
}

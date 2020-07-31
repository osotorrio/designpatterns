namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    public class OneThounsandWonBankNoteProduct : AbstractBanknoteProduct
    {
        public int Value => 1000;

        public string CurrencyCode => "KRW";

        public string Color => "Blue";
    }

    public class FiveThounsandWonBankNoteProduct : AbstractBanknoteProduct
    {
        public int Value => 5000;

        public string CurrencyCode => "KRW";

        public string Color => "LightRed";
    }

    public class TenThounsandWonBankNoteProduct : AbstractBanknoteProduct
    {
        public int Value => 10000;

        public string CurrencyCode => "KRW";

        public string Color => "Green";
    }

    public class FittyThounsandWonBankNoteProduct : AbstractBanknoteProduct
    {
        public int Value => 50000;

        public string CurrencyCode => "KRW";

        public string Color => "Orange";
    }
}

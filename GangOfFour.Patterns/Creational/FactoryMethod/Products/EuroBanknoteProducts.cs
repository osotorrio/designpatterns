namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    public class FiveEuroBanknoteProduct : AbstractBanknoteProduct
    {
        public int Value => 5;

        public string CurrencyCode => "EUR";

        public string Color => "DarkBlue";
    }

    public class TenEuroBanknoteProduct : AbstractBanknoteProduct
    {
        public int Value => 10;

        public string CurrencyCode => "EUR";

        public string Color => "Pink";
    }

    public class TwentyEuroBanknoteProduct : AbstractBanknoteProduct
    {
        public int Value => 20;

        public string CurrencyCode => "EUR";

        public string Color => "LightBlue";
    }

    public class FittyEuroBanknoteProduct : AbstractBanknoteProduct
    {
        public int Value => 50;

        public string CurrencyCode => "EUR";

        public string Color => "Orange";
    }
    public class OneHundredEuroBanknoteProduct : AbstractBanknoteProduct
    {
        public int Value => 100;

        public string CurrencyCode => "EUR";

        public string Color => "Green";
    }
    public class TwoHundredEuroBanknoteProduct : AbstractBanknoteProduct
    {
        public int Value => 200;

        public string CurrencyCode => "EUR";

        public string Color => "Yellow";
    }
}

namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    public abstract class AbstractBanknoteProduct
    {
        int Value { get; }

        string CurrencyCode { get; }

        string Color { get; }

        public override string ToString()
        {
            return $"{Value} {CurrencyCode} color {Color}";
        }
    }
}

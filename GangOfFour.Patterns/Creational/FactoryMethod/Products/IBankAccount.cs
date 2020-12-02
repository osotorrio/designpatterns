namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    public interface IBankAccount
    {
        bool OpenAccount(params string[] holders);

        void CreditAccount(decimal amount);
    }
}

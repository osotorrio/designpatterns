namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    public interface IBankAccount
    {
        bool OpenAccount(string holder);

        void CreditAccount(decimal amount);
    }
}

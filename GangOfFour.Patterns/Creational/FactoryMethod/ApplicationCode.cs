using GangOfFour.Patterns.Creational.FactoryMethod.Creators;
using Xunit;

namespace GangOfFour.Patterns.Creational.FactoryMethod
{
    public class ApplicationCode
    {
        [Fact]
        public void ExampleFactoryMethodPattern()
        {
            AbstractBanknoteCreator euro = new EuroBanknoteCreator();
            euro.CreateBanknotesFactoryMethod();

            foreach (var banknote in euro.Banknotes)
            {
                banknote.ToString();
            }
        }
    }
}

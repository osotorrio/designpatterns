namespace GangOfFour.Patterns.Creational.FactoryMethod.Stuff
{
    public interface IRunCreditChecks
    {
        bool CheckHolder(string holder);
    }

    public class CreditCheck : IRunCreditChecks
    {
        public bool CheckHolder(string holder)
        {
            throw new System.NotImplementedException();
        }
    }
}

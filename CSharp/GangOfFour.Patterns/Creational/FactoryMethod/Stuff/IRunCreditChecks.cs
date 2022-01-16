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
            /*
                Here the code to run a security credit check on the account holder.
            */

            return true;
        }
    }
}

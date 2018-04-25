namespace GangOfFour.Patterns.Creational.Adapter.Target
{
    /// <summary>
    /// TARGET:
    /// Interface expected by our own code. Our business logic is using this contract to do some stuff
    /// </summary>
    public interface IArithmeticCalculate
    {
        double Addition(double x, double y);

        double Subtraction(double x, double y);

        double Multiplication(double x, double y);

        double Division(double x, double y);
    }
}

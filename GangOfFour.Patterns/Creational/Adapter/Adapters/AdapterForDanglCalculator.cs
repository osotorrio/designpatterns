using Dangl.Calculator;
using GangOfFour.Patterns.Creational.Adapter.Target;

namespace GangOfFour.Patterns.Creational.Adapter
{
    /// <inheritdoc />
    /// <summary>
    /// ADAPTER:
    /// The nuget package Dangl.Calculator is the ADAPTEE. it is an external tool with lot of math operations
    /// We cannot use it directly in our CLIENT code because it has a different interface.
    /// Therefore we ADAPT it!!
    /// </summary>
    public class AdapterForDanglCalculator : IArithmeticCalculate
    {
        public double Addition(double x, double y)
        {
            return Calculate($"{x}+{y}");
        }
        
        public double Subtraction(double x, double y)
        {
            return Calculate($"{x}-{y}");
        }

        public double Multiplication(double x, double y)
        {
            return Calculate($"{x}*{y}");
        }

        public double Division(double x, double y)
        {
            return Calculate($"{x}/{y}");
        }

        private static double Calculate(string expression)
        {
            var calculation = Calculator.Calculate(expression);
            return calculation.Result;
        }
    }
}
